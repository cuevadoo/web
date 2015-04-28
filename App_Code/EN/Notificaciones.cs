using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Notificaciones
/// </summary>
namespace EN
{
    public class Notificaciones
    {
        private GrupoAmigos grupoami;
        private MensajeDifusion mendifusion;
        private MensajePrivado menprivado;
        private Chat chat;

        public Notificaciones(GrupoAmigos grupoami,MensajeDifusion mendifusion,MensajePrivado menprivado,Chat chat)
        {
            this.grupoami = grupoami;
            this.mendifusion = mendifusion;
            this.menprivado = menprivado;
            this.chat = chat;
        }

        public GrupoAmigos Grupoami
        {
            get { return grupoami; }
            set { grupoami = value; }
        }

        public MensajeDifusion Mendifusion
        {
            get { return mendifusion; }
            set { mendifusion = value; }
        }

        public MensajePrivado Menprivado
        {
            get { return menprivado; }
            set { menprivado = value; }
        }

        public Chat Chat
        {
            get { return chat; }
            set { chat = value; }
        }
    }
}