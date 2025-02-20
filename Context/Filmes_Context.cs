﻿using API_filmes_senai.Domains;
using API_filmes_senai.Domains.Filme;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace API_filmes_senai.Context
{
    public class Filmes_Context : DbContext
    {
        public Filmes_Context()
        { }
        public Filmes_Context(DbContextOptions<Filmes_Context> options) : base(options)
        {
        }

        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filme> Filme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {


                optionsBuilder.UseSqlServer("server = DESKTOP-0L5VRFL\\SQLEXPRESS; Database = Filmes; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");

            
            }
        }
    }
}