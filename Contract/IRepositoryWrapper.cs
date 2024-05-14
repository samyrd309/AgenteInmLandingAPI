using Contracts.InterfaceRepository;

namespace Contracts{
    public interface IRepositoryWrapper
    {
        IPropiedadRepository Propiedad { get; } 
        IAgenteInmobiliarioRepository AgenteInmobiliario { get; }
        IClienteRepository Cliente { get; }
        IVisitaRepository Visita { get; } 
        ITipoPropiedadRepository TipoPropiedad { get; }
        ICiudadRepository Ciudad { get; }
        void Save();
    }
}