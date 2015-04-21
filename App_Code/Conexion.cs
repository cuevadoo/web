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
    public DataTable ejecutarT(string comando){
        DataSet contenido = new DataSet();
        comandos.CommandText = comando;
        try { adaptador.Fill(contenido, "cosas"); }catch (SqlCeException ex) {}
        return contenido.Tables["cosas"];
    }
    public DataSet ejecutarS(string comando){
        DataSet contenido = new DataSet();
        comandos.CommandText = comando;
        try { adaptador.Fill(contenido, "cosas"); }
        catch (SqlCeException ex) { }
        return contenido;
    }
}