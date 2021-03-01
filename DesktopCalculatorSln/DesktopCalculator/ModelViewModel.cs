using Simplified;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCalculator
{
    public class ModelViewModel : BaseInpc
    {
        private decimal _display;

        /// <summary>Свойство для текста дисплея.
        /// Пока decimal, но возможно придётся изменить на string.</summary>
        public decimal Display { get => _display; private set => Set(ref _display, value); }

        /// <summary>Нужно для инициализации команды (Один из способов).</summary>
        private RelayCommand<string>? _clickKeyCommand;

        /// <summary>Команда клика по клавише.
        /// В параметре получает текст идентифицирующий клавишу.</summary>
        public RelayCommand<string> ClickKeyCommand => _clickKeyCommand 
            ??(_clickKeyCommand = new RelayCommand<string>(ClickKeyExecute, ClickKeyCanExecute));

        /// <summary>Проверяющий метод команды.</summary>
        /// <param name="parameter">Текст идентифицирующий клавишу></param>
        /// <returns>Возвращает <see langword="true"/>, если выполнение
        /// команды с этим параметром разрешено.</returns>
        private bool ClickKeyCanExecute(string parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>Исполнительный метод команды.</summary>
        /// <param name="parameter">Текст идентифицирующий клавишу></param>
        private void ClickKeyExecute(string parameter)
        {
            throw new NotImplementedException();
        }

        protected override void OnPropertyChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnPropertyChanged(propertyName, oldValue, newValue);

            // Если изменилось значение свойства Display,
            // то вызывается перепроверка команды.
            if (propertyName == nameof(Display))
                ClickKeyCommand.RaiseCanExecuteChanged();
        }
    }

}
