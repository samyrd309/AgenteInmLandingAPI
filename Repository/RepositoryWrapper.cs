using Contracts;
using Contracts.InterfaceRepository;
using Entities;
using Repository.ModelsRepository;

namespace Repository{
    public class RepositoryWrapper : IRepositoryWrapper{
        private RepositoryContext _repoContext;
        private IAgenteInmobiliarioRepository _agenteInmobiliario;
        private IClienteRepository _cliente;
        private IPropiedadRepository _propiedad;
        private IVisitaRepository _visita;
        private ITipoPropiedadRepository _tipoPropiedad;

        public IPropiedadRepository Propiedad {
            get {
                if (_propiedad == null)
                {
                    _propiedad = new PropiedadRepository(_repoContext);
                }
                return _propiedad;
            }
        }

        public IAgenteInmobiliarioRepository AgenteInmobiliario{
            get{
                if (_agenteInmobiliario == null)
                {
                    _agenteInmobiliario = new AgenteInmobiliarioRepository(_repoContext);
                }
                return _agenteInmobiliario;
            }
        }

        public IClienteRepository Cliente{
            get{
                if (_cliente == null)
                {
                    _cliente = new ClienteRepository(_repoContext);
                }
                return _cliente;
            }
        
        }

        public IVisitaRepository Visita{
            get{
                if (_visita == null)
                {
                    _visita = new VisitaRepository(_repoContext);
                }
                return _visita;
            }
        }

        public ITipoPropiedadRepository TipoPropiedad{
            get{
                if (_tipoPropiedad == null)
                {
                    _tipoPropiedad = new TipoPropiedadRepository(_repoContext);
                }
                return _tipoPropiedad;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext){
            _repoContext = repositoryContext;
            _agenteInmobiliario = new AgenteInmobiliarioRepository(_repoContext);
            _cliente = new ClienteRepository(_repoContext);
            _propiedad = new PropiedadRepository(_repoContext);
            _visita = new VisitaRepository(_repoContext);
            _tipoPropiedad = new TipoPropiedadRepository(_repoContext);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}