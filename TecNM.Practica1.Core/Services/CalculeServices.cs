using TecNM.Practica1.Core.Entities;

using TecNM.Practica1.Core.Enums;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class CalculeServices: ICalculeWService
{
    public CalculeW ProcessCalcule(Person person){

        var cal = new CalculeW();
            cal.pesoMarte = person.weight * ((double)CalculeType.MARTE / 100);
            cal.pesoLuna = person.weight * ((double)CalculeType.LUNA / 100);
            cal.pesoVenus = person.weight * ((double)CalculeType.VENUS / 100);
            cal.pesoUrano = person.weight * ((double)CalculeType.URANO / 100);
            cal.pesoMercurio = person.weight * ((double)CalculeType.MERCURIO / 100);
            cal.pesoSaturno = person.weight * ((double)CalculeType.SATURNO / 100);

        return cal;
    }
}