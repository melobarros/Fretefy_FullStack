import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { RegiaoService } from '../../services/regiao.service';
import { CidadeService } from '../../services/cidade.service';
import { Cidade } from 'src/app/models/cidade.model';
import { Regiao } from 'src/app/models/regiao.model';
import { v4 as uuidv4 } from 'uuid';

@Component({
  selector: 'app-regiao-form',
  templateUrl: './regiao-form.component.html',
  styleUrls: ['./regiao-form.component.scss']
})
export class RegiaoFormComponent implements OnInit {
  regiaoForm: FormGroup;
  cidades: Cidade[] = [];
  isEditMode: boolean = false;
  regiaoId = this.route.snapshot.paramMap.get('id');

  constructor(
    private fb: FormBuilder,
    private regiaoService: RegiaoService,
    private cidadeService: CidadeService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.regiaoForm = this.fb.group({
      id: [null],
      nome: ['', [Validators.required]],
      ativo: [true],
      cidades: this.fb.array([])
    });

    this.cidadeService.list().subscribe(cidades => {
      this.cidades = cidades;
    });

    if (this.regiaoId) {
      this.isEditMode = true;
      this.regiaoService.getRegiaoById(this.regiaoId).subscribe(regiao => {
        this.regiaoForm.patchValue({
          id: regiao.id,
          nome: regiao.nome,
          ativo: regiao.ativo
        });
        this.setCidades(regiao.cidades);
      });
    }
  }

  get cidadesFormArray(): FormArray {
    return this.regiaoForm.get('cidades') as FormArray;
  }

  setCidades(cidades: Cidade[]): void {
    const cidadeControls = cidades.map(cidade => this.fb.group({
      id: [cidade.id],
      nome: [cidade.nome],
      uf: [cidade.uf]
    }));
    this.cidadesFormArray.clear();
    cidadeControls.forEach(control => this.cidadesFormArray.push(control));
  }

  addCidadeControl(): void {
    this.cidadesFormArray.push(this.fb.group({
      id: [null],
      nome: [''],
      uf: ['']
    }));
  }

  removeCidadeControl(index: number): void {
    this.cidadesFormArray.removeAt(index);
  }

  onSubmit(): void {
    if (this.regiaoForm.valid) {
      const regiaoFormValue = this.regiaoForm.value;

      const regiaoPayload: Regiao = {
        id: this.regiaoId ? this.regiaoId : uuidv4(),
        nome: regiaoFormValue.nome,
        ativo: regiaoFormValue.ativo,
        cidades: regiaoFormValue.cidades.map(cidade => ({
          id: cidade.id,
          nome: this.cidades.find(c => c.id === cidade.id).nome,
          uf: this.cidades.find(c => c.id === cidade.id).uf
        }))
      };

      if (this.isEditMode) {
        this.regiaoService.updateRegiao(regiaoPayload.id, regiaoPayload).subscribe(() => {
          this.router.navigate(['/regiao']);
        });
      } else {
        this.regiaoService.createRegiao(regiaoPayload).subscribe(() => {
          this.router.navigate(['/regiao']);
        });
      }
    }
  }
}
