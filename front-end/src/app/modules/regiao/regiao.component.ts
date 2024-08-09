import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Regiao } from 'src/app/models/regiao.model';
import { RegiaoService } from 'src/app/services/regiao.service';

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss']
})
export class RegiaoComponent implements OnInit {
  regioes: Observable<Regiao[]>;

  constructor(private regiaoService: RegiaoService, private router: Router) { }

  ngOnInit(): void {
    this.carregarRegioes();
  }

  carregarRegioes(): void {
    this.regioes = this.regiaoService.getRegioes();
  }

  openAddForm() {
    this.router.navigate(['/regiao/adicionar']);
  }

  exportar(): void {
    this.regiaoService.exportRegioes().subscribe(response => {
      const blob = new Blob([response], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' });
      const url = window.URL.createObjectURL(blob);
      const link = document.createElement('a');
      link.href = url;
      link.download = `Regioes_${new Date().toLocaleString()}.xlsx`;
      link.click();
    });
  }

  toggleStatus(regiao: Regiao): void {
    this.regiaoService.toggleAtiva(regiao.id).subscribe(
      () => {
        this.carregarRegioes();
      },
      (error) => {
        console.error('Erro ao alterar o status da região:', error);
      }
    );
  }

  edit(id: string): void {
    this.router.navigate(['/regiao/editar', id]);
  }

  delete(regiao: Regiao): void {
    if (confirm(`Tem certeza que deseja deletar a região "${regiao.nome}"?`)) {
      this.regiaoService.deleteRegiao(regiao.id).subscribe(
        () => {
          this.carregarRegioes();
        },
        (error) => {
          console.error('Erro ao deletar a região:', error);
        }
      );
    }
  }

}
