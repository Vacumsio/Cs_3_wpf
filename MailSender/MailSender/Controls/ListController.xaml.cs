using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailSender.Controls
{
    /// <summary>
    /// Логика взаимодействия для ListController.xaml
    /// </summary>
    public partial class ListController
    {
        #region Items Property
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register(
                "Items",
                typeof(IEnumerable),
                typeof(ListController),
                new PropertyMetadata(default(IEnumerable), OnItemsChanged, ItemsSourceValue),
                ItemsValidate
                );

        private static bool ItemsValidate(object value)
        {
            return true;
        }

        private static object ItemsSourceValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        private static void OnItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        public IEnumerable Items
        {
            get => (IEnumerable)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }
        #endregion

        #region SelectedItem : object - Выбранный элемент

        /// <summary>
        /// Выбранный элемент
        /// </summary>

        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
                nameof(SelectedItem),
                typeof(object),
                typeof(ListController),
                new PropertyMetadata(default(object))
                );
        [Description("Выбранный элемент")]

        public object SelectedItem
        {
            get => (object)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
                    
        }

        #endregion

        #region PanelName : String - название панели

        /// <summary>
        /// Выбранный элемент
        /// </summary>

        public static readonly DependencyProperty PanelNameProperty =
            DependencyProperty.Register(
                nameof(PanelName),
                typeof(String),
                typeof(ListController),
                new PropertyMetadata(default(String))
                );
        [Description("Выбранный элемент")]

        public String PanelName
        {
            get => (String)GetValue(PanelNameProperty);
            set => SetValue(PanelNameProperty, value);

        }

        #endregion

        #region SelectedItemIndex : int - Индекс выбранного элемента

        /// <summary>
        /// Индекс выбранного элемента
        /// </summary>

        public static readonly DependencyProperty SelectedItemIndexProperty =
            DependencyProperty.Register(
                nameof(SelectedItemIndex),
                typeof(int),
                typeof(ListController),
                new PropertyMetadata(default(int))
                );
        [Description("Индекс выбранного элемента")]

        public int SelectedItemIndex
        {
            get => (int)GetValue(SelectedItemIndexProperty);
            set => SetValue(SelectedItemIndexProperty, value);
        }

        #endregion

        #region ViewPropertyPath : string - Имя отображаемого свойства

        /// <summary>
        /// Имя отображаемого свойства
        /// </summary>

        public static readonly DependencyProperty ViewPropertyPathProperty =
            DependencyProperty.Register(
                nameof(ViewPropertyPath),
                typeof(string),
                typeof(ListController),
                new PropertyMetadata(default(string))
                );
        [Description("Имя отображаемого свойства")]

        public string ViewPropertyPath
        {
            get => (string)GetValue(ViewPropertyPathProperty);
            set => SetValue(ViewPropertyPathProperty, value);
        }

        #endregion

        #region ValuePropertyPath : string - Имя свойства значения

        /// <summary>
        /// Имя свойства значения
        /// </summary>

        public static readonly DependencyProperty ValuePropertyPathProperty =
            DependencyProperty.Register(
                nameof(ValuePropertyPath),
                typeof(string),
                typeof(ListController),
                new PropertyMetadata(default(string))
                );
        [Description("Имя свойства значения")]

        public string ValuePropertyPath
        {
            get => (string)GetValue(ValuePropertyPathProperty);
            set => SetValue(ValuePropertyPathProperty, value);
        }

        #endregion

        #region CreateCommand : ICommand - Команда создания нового значения

        /// <summary>
        /// Команда создания нового значения
        /// </summary>

        public static readonly DependencyProperty CreateCommandProperty =
            DependencyProperty.Register(
                nameof(CreateCommand),
                typeof(ICommand),
                typeof(ListController),
                new PropertyMetadata(default(ICommand))
                );
        [Description("Команда создания нового значения")]

        public ICommand CreateCommand
        {
            get => (ICommand)GetValue(CreateCommandProperty);
            set => SetValue(CreateCommandProperty, value);
        }

        #endregion

        #region EditCommand : ICommand - Команда редактирования значения

        /// <summary>
        /// Команда редактирования значения
        /// </summary>

        public static readonly DependencyProperty EditCommandProperty =
            DependencyProperty.Register(
                nameof(EditCommand),
                typeof(ICommand),
                typeof(ListController),
                new PropertyMetadata(default(ICommand))
                );
        [Description("Команда редактирования значения")]

        public ICommand EditCommand
        {
            get => (ICommand)GetValue(EditCommandProperty);
            set => SetValue(EditCommandProperty, value);
        }

        #endregion



        public ListController() => InitializeComponent();
    }
}
