using System.Collections.ObjectModel;

namespace WpfApp.Model
{
    public abstract class ViewModelBase<T> where T : class

    {
        private DataContextModel _context;

        public ViewModelBase()
        {
            _context = new DataContextModel();
        }

        private T _atual;

        public T atual
        {
            get { return _atual; }
            set { _atual = value; }
        }

        private ObservableCollection<T> _itens;

        public ObservableCollection<T> Itens
        {
            get
            {
                if (_itens == null)
                    _itens = new ObservableCollection<T>(_context.Set<T>());
                return _itens;
            }
        }

        public void AdicionarAtual()
        {
            _context.Set<T>().Add(_atual);
            _context.SaveChanges();
            _itens.Add(_atual);
        }

        public void RemoverAtual()
        {
            _context.Set<T>().Remove(_atual);
            _context.SaveChanges();
            _itens.Remove(_atual);
        }

        public void EditarAtual()
        {
            _context.Entry(_atual).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void RestaurarAtual()
        {
            _context.Entry(_atual).Reload();
        }

    }
}
