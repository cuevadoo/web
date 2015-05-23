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
    private byte hora;
    private byte minuto;
    private byte segundo;

   
    public Fecha() {}
    private bool fcompleta=false;
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
    public Fecha(DateTime fecha)
    {
        fcompleta=true;
        this.dia = (byte)fecha.Day;
        this.mes = (byte)fecha.Month;
        this.año = fecha.Year;
        this.hora = (byte)fecha.Hour;
        this.minuto = (byte)fecha.Minute;
        this.segundo = (byte)fecha.Second;
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
    public byte Hora {
        get { return hora; }
        set { hora = value; }
    }
    public byte Minuto
    {
        get { return minuto; }
        set { minuto = value; }
    }
    public byte Segundo
    {
        get { return segundo; }
        set { segundo = value; }
    }
    public String imprimirSql(){
        if (!fcompleta)
        {
            return año + "-" + mes + "-" + dia;
        }
        else { return año + "-" + mes + "-" + dia + " " + hora + ":" + minuto + ":" + segundo; }
    }
    public void traducirSql(DateTime date) {
        año = date.Year;
        mes = (byte)date.Month;
        dia = (byte)date.Day;
        hora = (byte)date.Hour;
        minuto = (byte)date.Minute;
        segundo = (byte)date.Second;
    }
}