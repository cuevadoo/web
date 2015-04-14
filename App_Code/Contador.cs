using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Contador
/// </summary>
public class Contador
{
    int cont = 0;
	public Contador(){
	}
    public static Contador operator++(Contador c){
        c.cont =c.cont + 1;
        return c;
    }
    public String ToString(){
        return ""+cont;
    }
}