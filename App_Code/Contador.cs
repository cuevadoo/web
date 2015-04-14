using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Contador
/// </summary>
public class Contador
{
    int min;
    int max;
    int cont;
    public Contador(){
        this.min = 0; this.max = int.MaxValue; this.cont = 0;
    }
    public Contador(int max){
        this.min = 0; this.max = max; this.cont = 0;
    }
    public Contador(int min,int max){
        this.min = min; this.max = max; this.cont = 0;
    }
    public Contador(int min, int max,int cont){
        this.min = min; this.max = max; this.cont = cont;
    }
    public static Contador operator++(Contador c){
        if(c.cont!=c.max){
            c.cont= c.cont + 1;
        }
        else{
            c.cont= c.min;
        }
        return c;
    }
    public override String ToString(){
        return ""+cont;
    }
    public int ToInt() {
        return cont;
    }
}