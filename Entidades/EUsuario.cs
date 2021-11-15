using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public class EUsuario
	{
		public string ClaveUsuario {get; set;}
		public string CURP { get; set; }
		public string Nombre { get; set; }
		public string ApPaterno { get; set; }
		public string ApMaterno { get; set; }
		public string FechaNacimiento { get; set; }
		public string Email { get; set; }
		public string Direccion { get; set; }

		public EUsuario()
		{
			ClaveUsuario = string.Empty;
			CURP = string.Empty;
			Nombre = string.Empty;
			ApPaterno = string.Empty;
			ApMaterno = string.Empty;
			FechaNacimiento = string.Empty;
			Email = string.Empty;
			Direccion = string.Empty;
		}

		public EUsuario(string clave, string curp = "", string nom = "", string apPat = "",
			string apMat = "", string fechNac = "",
			string persEmail = "", string dir = "")
        {
			ClaveUsuario = clave;
			CURP = curp;
			Nombre = nom;
			ApPaterno = apPat;
			ApMaterno = apMat;
			FechaNacimiento = fechNac;
			Email = persEmail;
			Direccion = dir;
        }
	}
}
