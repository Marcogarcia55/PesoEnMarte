using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;


namespace TecNM.Practica1.Core.Managers;

public class CalculeWManager: ICalculeWManager
{
    private readonly ICalculeWService _service;

    public CalculeWManager(ICalculeWService service){
        _service = service;
    }

    public CalculeW GetCal(Person person){
        return _service.ProcessCalcule(person);
    }
}

