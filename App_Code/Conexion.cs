using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion{
    private SqlDataAdapter adaptador = new SqlDataAdapter();
    private SqlConnection conexion = new SqlConnection();
    private SqlCommand comandos= new SqlCommand();
    public Conexion(){
        comandos.Connection = conexion;
        adaptador.SelectCommand = comandos;
        conexion.ConnectionString = BD.String();
	}
    public DataSet ejecutar(string comando){
        DataSet contenido = new DataSet();
        comandos.CommandText = comando;
        try { conexion.Open(); }catch(SqlException ex){}
        adaptador.Fill(contenido,"cosas");
        conexion.Close();
        return contenido;
    }
}