using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlServerCe;
using System.Data;

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
    public void ejecutarS(String comando) {
        comandos.CommandText = comando;
        try {
            conexion.Open();
            comandos.ExecuteNonQuery();
        }catch(Exception ex){
            throw ex;
        }finally {
            if (conexion != null) conexion.Close();
        }
    }
    public DataTable ejecutarR(string comando){
        DataSet contenido = new DataSet();
        try {
            comandos.CommandText = comando;
            adaptador.Fill(contenido, "cosas");
        }catch (Exception ex){
            throw ex;
        }finally {
            if (conexion != null) conexion.Close();
        }
        return contenido.Tables["cosas"];
    }
    public DataSet ejecutarR(string[] comando){
        DataSet contenido = new DataSet();
        int i = 0;
        try {
            foreach(String c in comando){
                comandos.CommandText = c;
                adaptador.Fill(contenido, "C"+i);
                
                i++;
            }
        }catch (Exception ex){
            throw ex;
        }finally {
            if (conexion != null) conexion.Close();
        }
        return contenido;
    }
}