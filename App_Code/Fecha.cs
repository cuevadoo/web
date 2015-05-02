using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Fecha
/// </summary>
public class Fecha
{
    private byte dia;
    private byte mes;
    private int año;
    public Fecha() {}
	public Fecha(int dia,int mes,int año){
        this.dia = (byte)dia;
        this.mes = (byte)mes;
        this.año = año;
	}
    public Fecha(byte dia,byte mes,int año) {
        this.dia = dia;
        this.mes = mes;
        this.año = año;
    }
    public byte Dia{
        get { return dia; }
        set { dia = value; }
    }
    public byte Mes{
        get { return mes; }
        set { mes = value; }
    }
    public int Año{
        get { return año; }
        set { año = value; }
    }
    public String imprimirSql(){
        return año + "-" + mes + "-" + dia;
    }
    public void traducirSql(DateTime date) {
        año = date.Year;
        mes = (byte)date.Month;
        dia = (byte)date.Day;
    }
}