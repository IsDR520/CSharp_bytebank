﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_0_ByteBank
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set 
            {
                // Escrevo minha lógica de validação de cpf
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}