﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exame2019.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Exame2019.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O código não pode ser vazio..
        /// </summary>
        internal static string ERRO_CODIGO_VAZIO {
            get {
                return ResourceManager.GetString("ERRO_CODIGO_VAZIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Valor superior à data de hoje.
        /// </summary>
        internal static string ERRO_DATA_SUPERIOR_HOJE {
            get {
                return ResourceManager.GetString("ERRO_DATA_SUPERIOR_HOJE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A idade não pode ser negativa..
        /// </summary>
        internal static string ERRO_IDADE_CIDADAO_NEGATIVA {
            get {
                return ResourceManager.GetString("ERRO_IDADE_CIDADAO_NEGATIVA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O Nome tem de ter no mínimo 3 caracteres.
        /// </summary>
        internal static string ERRO_NOME_3DIGITOS {
            get {
                return ResourceManager.GetString("ERRO_NOME_3DIGITOS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erro: {0} \n Caminho: {1}.
        /// </summary>
        internal static string GLOBAL_ERROR {
            get {
                return ResourceManager.GetString("GLOBAL_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gravado com sucesso..
        /// </summary>
        internal static string GLOBAL_GRAVADO_COM_SUCESSO {
            get {
                return ResourceManager.GetString("GLOBAL_GRAVADO_COM_SUCESSO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eliminar.
        /// </summary>
        internal static string GLOBAL_MENU_ELIMINAR {
            get {
                return ResourceManager.GetString("GLOBAL_MENU_ELIMINAR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gravar.
        /// </summary>
        internal static string GLOBAL_MENU_GRAVAR {
            get {
                return ResourceManager.GetString("GLOBAL_MENU_GRAVAR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Novo.
        /// </summary>
        internal static string GLOBAL_MENU_NOVO {
            get {
                return ResourceManager.GetString("GLOBAL_MENU_NOVO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sair.
        /// </summary>
        internal static string GLOBAL_MENU_SAIR {
            get {
                return ResourceManager.GetString("GLOBAL_MENU_SAIR", resourceCulture);
            }
        }
    }
}
