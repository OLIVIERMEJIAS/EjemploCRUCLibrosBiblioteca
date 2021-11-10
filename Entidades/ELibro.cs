﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ELibro
    {
        #region Atributos
        string claveLibro;
        string titulo;
        string claveAutor;
        ECategoria categoria;
        bool existe;
        #endregion

        #region Propiedades
        public string ClaveLibro { get; set; }
        public string Titulo { get; set; }
        public string ClaveAutor { get; set; }
        public ECategoria Categoria { get; set; }
        public bool Existe { get; set; }
        #endregion

        #region Constructores
        public ELibro()
        {
            ClaveLibro = string.Empty;
            Titulo = string.Empty;
            ClaveAutor = string.Empty;
            Categoria = new ECategoria();
            Existe = false;
        }
        public ELibro(string claLibro,string tit,
            string claAutor,ECategoria cate, bool ext)
        {
            ClaveLibro = claLibro;
            Titulo = tit;
            ClaveAutor = claAutor;
            Categoria = cate;
            Existe = ext;
        }
        #endregion
    }
}
