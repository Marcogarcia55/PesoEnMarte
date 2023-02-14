using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Managers.Interfaces;

public interface ICalculeWManager
{
    CalculeW GetCal(Person person);
    
}