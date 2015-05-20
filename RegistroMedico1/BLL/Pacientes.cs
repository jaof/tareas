using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace RegistroMedic.BLL
{
    public class Pacientes
    {
    public int IdPaciente {get;set;}
    public string Nombre{get;set;}
    public string Apellido{get;set;}
    public string Direccion {get;set;}
    public string Telefono { get; set; }
    public string Celular { get; set; }
    public string Cedula { get; set; }
    public DateTime FechaNac { get; set; }
    public DateTime FechaIng { get; set; }
    public int Sexo { get; set; }
    public string Ocupacion﻿ { get; set; }

    public  DAL.Conexion ConexiondB =new DAL.Conexion();
        
        public Pacientes() 
        {
         
            Nombre = "";
            Apellido = "";
            Direccion = "";
            Telefono = "";
            Celular = "";
            Cedula = "";
            FechaNac = DateTime.Now;
            FechaIng = DateTime.Now;
            Sexo = 0 ;
            Ocupacion = "";
        
        }
        
        public bool Insertar()
        {
            return ConexiondB.EjecutarDB("Insert Into Pacientes(Nombre,Apellido,Direccion,Telefono,Celular,Cedula,FechaNac,FechaIng,Sexo,Ocupacion)Values('" + Nombre +
              "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Celular + "','" + Cedula + "','" + FechaNac.ToString("MM/dd/yyyy") + "','" + FechaIng.ToString("MM/dd/yyyy") + "','" + Sexo + "','" + Ocupacion + "')");

        }

        public bool Modificar(string IdCliente)
        {
            return ConexiondB.EjecutarDB("Update Pacientes set Nombre='" + Nombre + "',Apellido ='" + Apellido + "',Direccion ='" + Direccion +
                "',Telefono ='" + Telefono + "',Celular ='" + Celular + "' ,Cedula ='" + Cedula + "',FechaNac='" + FechaNac.ToString("MM/dd/yyyy") + "',FechaIng ='" + FechaIng.ToString("MM/dd/yyyy") + "',Sexo='" + Sexo + "',Ocupacion ='" + Ocupacion + "'where IdPaciente='" + IdPaciente + "' "); 

        }

        public bool Eliminar(string IdPaciente)
        {
            return ConexiondB.EjecutarDB("Delete from Pacientes where IdPaciente=" + IdPaciente);
        }

        public bool Buscar(int IdPaciente)
        { 
            bool mesj=false;
            DataTable dt =new DataTable();
            dt= ConexiondB.BuscarDb("Select *from Pacientes where IdPaciente="+IdPaciente);
            if(dt.Rows.Count>0)
            {
           
                Nombre= dt.Rows[0]["Nombre"].ToString();
                Apellido= dt.Rows[0]["Apellido"].ToString();
                Direccion = dt.Rows[0]["Direccion"].ToString();
                Telefono= dt.Rows[0]["Telefono"].ToString();
                Celular = dt.Rows[0]["Celular"].ToString();
                Cedula= dt.Rows[0]["Cedula"].ToString();
                FechaNac= (DateTime) dt.Rows[0]["FechaNac"];
                FechaIng= (DateTime)dt.Rows[0]["FechaIng"];
                Sexo = (int)dt.Rows[0]["Sexo"];
                Ocupacion = dt.Rows[0]["Ocupacion"].ToString();

                mesj=true;
        

            }
            return mesj;
        }
        
        public static DataTable Lista(String Campos, String FiltroWhere)
        {
            DAL.Conexion c=new DAL.Conexion();
            return c.BuscarDb("Select "+Campos+" from "+FiltroWhere);
        }
        public static DataTable ListarF(String fecha1, String fecha2,String Tipo)
        {
            DAL.Conexion ConexionDB = new DAL.Conexion();
            return ConexionDB.BuscarDb("select * from Pacientes where "+Tipo+" BETWEEN  ('" + fecha1 + "') and ('" + fecha2 + "') ");
        }

    


    

    }

}