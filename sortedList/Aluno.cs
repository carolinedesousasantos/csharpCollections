﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A41Dicionarios
{
    public class Aluno
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
        }

        private int numeroMatricula;
        public int NumeroMatricula
        {
            get { return numeroMatricula; }
        }

        public Aluno(String nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }
        public override string ToString()
        {
            return "[Aluno: " + this.nome + ", matricula: " + this.numeroMatricula + "]";
        }
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
            {
                return false;
            }

            return this.nome.Equals(outro.nome);
        }
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
        
    }
}