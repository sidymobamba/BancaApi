﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace BancaApi.Entities
{
    public class UtenteEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Banca")]
        public int IdBanca { get; set; }
        public BancaEntity? Banca { get; set; }

        [Required]
        [MaxLength(100)]
        public string NomeUtente { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Token { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public bool Bloccato { get; set; } = false;


    }
}
