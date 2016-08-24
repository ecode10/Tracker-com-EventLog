using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing;
using System.Diagnostics;

namespace Tracker.Windows
{
    public class Local
    {
        private Boolean criarFonte(string fonte)
        {
            try
            {
                EventSourceCreationData sourceData = new EventSourceCreationData(fonte, "Tracker");
                EventLog.CreateEventSource(sourceData);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean escreverLogGenerico(string source, string mensagem, 
            System.Diagnostics.EventLogEntryType tipoDeLog, int numeroErro)
        {
            try
            {
                System.Diagnostics.EventLog.WriteEntry(source, mensagem, tipoDeLog, numeroErro);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean escreverLogGenerico(string source, string mensagem, System.Diagnostics.EventLogEntryType tipoDeLog)
        {
            try
            {
                System.Diagnostics.EventLog.WriteEntry(source, mensagem, tipoDeLog);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean escreverLogGenerico(string source, string mensagem)
        {
            try
            {
                System.Diagnostics.EventLog.WriteEntry(source, mensagem);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Boolean escreverLogGenerico(string mensagem)
        {
            try
            {
                //if (!EventLog.SourceExists("Application"))
                //    criarFonte("WindowsTracker");

                System.Diagnostics.EventLog.WriteEntry("Application", mensagem);
                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
