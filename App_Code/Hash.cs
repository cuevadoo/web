using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Cryptography;

/// <summary>
/// Descripción breve de Hash
/// </summary>
public class Hash{
    public static string getHash(String cadena){
        String clave = "d0duij1j2jfia;lkopicx,adsdae|3loluadb3mbuqldxp15nfd0ufc[qtzm,uslp";
        SHA512 sha = new SHA512CryptoServiceProvider();
        byte[] hash = sha.ComputeHash(new UnicodeEncoding().GetBytes(cadena + clave));
        return Convert.ToBase64String(hash);
    }
}