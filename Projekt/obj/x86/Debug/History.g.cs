﻿#pragma checksum "C:\Users\ekrzkit\repo\IPM_Projekt\Projekt\History.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "517D2D11F48DF1BAF6C19965E6DFD055"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt
{
    partial class History : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_CalendarDatePicker_Date(global::Windows.UI.Xaml.Controls.CalendarDatePicker obj, global::System.Nullable<global::System.DateTimeOffset> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Nullable<global::System.DateTimeOffset>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Nullable<global::System.DateTimeOffset>), targetNullValue);
                }
                obj.Date = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class History_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHistory_Bindings
        {
            private global::Projekt.History dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.AppBarButton obj2;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj3;
            private global::Windows.UI.Xaml.Controls.CalendarDatePicker obj7;
            private global::Windows.UI.Xaml.Controls.CalendarDatePicker obj8;

            private History_obj1_BindingsTracking bindingsTracking;

            public History_obj1_Bindings()
            {
                this.bindingsTracking = new History_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // History.xaml line 14
                        this.obj2 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.Back_ItemClick(sender, e);
                        };
                        break;
                    case 3: // History.xaml line 15
                        this.obj3 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.Exit_ItemClick(sender, e);
                        };
                        break;
                    case 7: // History.xaml line 32
                        this.obj7 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)target;
                        this.bindingsTracking.RegisterTwoWayListener_7(this.obj7);
                        break;
                    case 8: // History.xaml line 33
                        this.obj8 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)target;
                        this.bindingsTracking.RegisterTwoWayListener_8(this.obj8);
                        break;
                    default:
                        break;
                }
            }

            // IHistory_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Projekt.History)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Projekt.History obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_historyDateViewModel(obj.historyDateViewModel, phase);
                    }
                }
            }
            private void Update_historyDateViewModel(global::HistoryDateViewModelNamespace.HistoryDateViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_historyDateViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_historyDateViewModel_DateTimeStart(obj.DateTimeStart, phase);
                        this.Update_historyDateViewModel_DateTimeEnd(obj.DateTimeEnd, phase);
                    }
                }
            }
            private void Update_historyDateViewModel_DateTimeStart(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // History.xaml line 32
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_CalendarDatePicker_Date(this.obj7, obj, null);
                }
            }
            private void Update_historyDateViewModel_DateTimeEnd(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // History.xaml line 33
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_CalendarDatePicker_Date(this.obj8, obj, null);
                }
            }
            private void UpdateTwoWay_7_Date()
            {
                if (this.initialized)
                {
                    this.dataRoot.historyDateViewModel.DateTimeStart = (global::System.DateTimeOffset)this.obj7.Date;
                }
            }
            private void UpdateTwoWay_8_Date()
            {
                if (this.initialized)
                {
                    this.dataRoot.historyDateViewModel.DateTimeEnd = (global::System.DateTimeOffset)this.obj8.Date;
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class History_obj1_BindingsTracking
            {
                private global::System.WeakReference<History_obj1_Bindings> weakRefToBindingObj; 

                public History_obj1_BindingsTracking(History_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<History_obj1_Bindings>(obj);
                }

                public History_obj1_Bindings TryGetBindingObject()
                {
                    History_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_historyDateViewModel(null);
                }

                public void PropertyChanged_historyDateViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    History_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::HistoryDateViewModelNamespace.HistoryDateViewModel obj = sender as global::HistoryDateViewModelNamespace.HistoryDateViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_historyDateViewModel_DateTimeStart(obj.DateTimeStart, DATA_CHANGED);
                                bindings.Update_historyDateViewModel_DateTimeEnd(obj.DateTimeEnd, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "DateTimeStart":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_historyDateViewModel_DateTimeStart(obj.DateTimeStart, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "DateTimeEnd":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_historyDateViewModel_DateTimeEnd(obj.DateTimeEnd, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::HistoryDateViewModelNamespace.HistoryDateViewModel cache_historyDateViewModel = null;
                public void UpdateChildListeners_historyDateViewModel(global::HistoryDateViewModelNamespace.HistoryDateViewModel obj)
                {
                    if (obj != cache_historyDateViewModel)
                    {
                        if (cache_historyDateViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_historyDateViewModel).PropertyChanged -= PropertyChanged_historyDateViewModel;
                            cache_historyDateViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_historyDateViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_historyDateViewModel;
                        }
                    }
                }
                public void RegisterTwoWayListener_7(global::Windows.UI.Xaml.Controls.CalendarDatePicker sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CalendarDatePicker.DateProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_7_Date();
                        }
                    });
                }
                public void RegisterTwoWayListener_8(global::Windows.UI.Xaml.Controls.CalendarDatePicker sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.CalendarDatePicker.DateProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_8_Date();
                        }
                    });
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 4: // History.xaml line 20
                {
                    this.grid_panel_history_page = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // History.xaml line 46
                {
                    this.grid_panel_chart = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // History.xaml line 57
                {
                    this.LineChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 7: // History.xaml line 32
                {
                    this.historyDateStart = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 8: // History.xaml line 33
                {
                    this.historyDateEnd = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // History.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    History_obj1_Bindings bindings = new History_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

