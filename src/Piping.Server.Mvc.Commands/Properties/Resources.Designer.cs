﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piping.Server.Mvc.Commands.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
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
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Piping.Server.Mvc.Commands.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   &lt;html&gt;
        ///&lt;head&gt;
        ///  &lt;title&gt;Piping&lt;/title&gt;
        ///  &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width,initial-scale=1&quot;&gt;
        ///  &lt;style&gt;
        ///    h3 {
        ///      margin-top: 2em;
        ///      margin-bottom: 0.5em;
        ///    }
        ///  &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///  &lt;h1&gt;Piping&lt;/h1&gt;
        ///  Streaming Data Transfer Server over HTTP/HTTPS
        ///  &lt;form method=&quot;POST&quot; id=&quot;file_form&quot; enctype=&quot;multipart/form-data&quot;&gt;
        ///    &lt;h3&gt;Step 1: Choose a file or text&lt;/h3&gt;
        ///
        ///    &lt;input type=&quot;checkbox&quot; id=&quot;inputMode&quot; onchange=&quot;toggleInputMode()&quot;&gt;: &lt;b&gt;Text mode&lt;/b&gt;&lt;br&gt;&lt;br&gt;
        ///
        ///    &lt;input type=&quot;file&quot; n [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Index {
            get {
                return ResourceManager.GetString("Index", resourceCulture);
            }
        }
    }
}
