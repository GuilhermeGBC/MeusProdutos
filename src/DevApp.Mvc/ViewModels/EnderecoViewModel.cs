﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace DevApp.Mvc.ViewModels
{
    public class EnderecoViewModel
    {

        public EnderecoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2 e {1} caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50 ,ErrorMessage = "O campo {0} precisa ter entre {2 e {1} caracteres", MinimumLength = 1)]
        public string Numero { get; set; }


        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2 e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter entre {2 e {1} caracteres", MinimumLength = 8)]
        public string Cep { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2 e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2 e {1} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }


        [HiddenInput] //Carrega o valor mas não aparece na tela
        public Guid FornecedorId { get; set; }
    }
}