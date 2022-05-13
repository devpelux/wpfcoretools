using System;
using System.Windows.Input;

namespace WpfCoreTools
{
    /// <summary>
    /// Defines a command with delegated Execute and CanExecute.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// Gets the Execute delegate.
        /// </summary>
        public Action<object?> ExecuteDelegate { get; }

        /// <summary>
        /// Gets the CanExecute delegate.
        /// </summary>
        public Predicate<object?>? CanExecuteDelegate { get; }

        /// <inheritdoc/>
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Initializes a new instance of <see cref="DelegateCommand"/> that is always executable.
        /// </summary>
        /// <param name="execute"><see cref="Action{T}"/> called when the command is invoked.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public DelegateCommand(Action<object?> execute) : this(execute, null) { }

        /// <summary>
        /// Initializes a new instance of <see cref="DelegateCommand"/>
        /// specifying a predicate that determines if the command can be executed or not.
        /// </summary>
        /// <param name="execute"><see cref="Action{T}"/> called when the command is invoked.</param>
        /// <param name="canExecute"><see cref="Predicate{T}"/> called when
        /// it is to be determined whether the command can be executed or not.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public DelegateCommand(Action<object?> execute, Predicate<object?>? canExecute)
        {
            ExecuteDelegate = execute ?? throw new ArgumentNullException(nameof(execute));
            CanExecuteDelegate = canExecute;
        }

        /// <inheritdoc/>
        public bool CanExecute(object? parameter) => CanExecuteDelegate == null || CanExecuteDelegate(parameter);

        /// <inheritdoc/>
        public void Execute(object? parameter) => ExecuteDelegate(parameter);
    }
}
