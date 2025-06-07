using erp_psicologia_classes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Sessions.Dto.CreateSession
{
    public class CreateSessionOutputDto
    {
        public bool Created { get; set; }
        public string Error { get; set; }
        public Session Session { get; set; }

        public CreateSessionOutputDto(bool created, string error = "")
        {
            Created = created;
            Error = error;
        }

        public CreateSessionOutputDto(bool created, Session session, string error = "")
        {
            Error = error;
            Created = created;
            Session = session;
        }
    }
}
