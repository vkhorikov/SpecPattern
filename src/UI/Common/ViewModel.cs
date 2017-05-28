using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


namespace UI.Common
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public virtual double Height => 300;
        public virtual double Width => 400;

        public event PropertyChangedEventHandler PropertyChanged;


        protected void Notify([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        protected void Notify<T>(Expression<Func<T>> propertyExpression)
        {
            var expression = propertyExpression.Body as MemberExpression;

            if (expression == null)
                throw new ArgumentException(propertyExpression.Body.ToString());

            Notify(expression.Member.Name);
        }
    }
}
