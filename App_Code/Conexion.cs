using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlServerCe;
using System.Data;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion{
    private SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
    private SqlCeConnection conexion = new SqlCeConnection();
    private SqlCeCommand comandos= new SqlCeCommand();
    public Conexion()
    {
        conexion.ConnectionString = BD.String();
        comandos.Connection = conexion;
        adaptador.SelectCommand = comandos;
	}
    public DataSet ejecutar(string comando){
        DataSet contenido = new DataSet();
        comandos.CommandText = comando;
        try { conexion.Open(); }catch(SqlCeException ex){}
        adaptador.Fill(contenido,"cosas");
        conexion.Close();
        return contenido;
    }
}