//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.Error
{

public sealed partial class ErrorStyleDlgOkCancel :  Error.ErrorStyle 
{
    public ErrorStyleDlgOkCancel(ByteBuf _buf)  : base(_buf) 
    {
        Btn1Name = _buf.ReadString();
        Btn2Name = _buf.ReadString();
        PostInit();
    }

    public static ErrorStyleDlgOkCancel DeserializeErrorStyleDlgOkCancel(ByteBuf _buf)
    {
        return new Error.ErrorStyleDlgOkCancel(_buf);
    }

    public string Btn1Name { get; private set; }
    public string Btn2Name { get; private set; }

    public const int __ID__ = 264343942;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Btn1Name:" + Btn1Name + ","
        + "Btn2Name:" + Btn2Name + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}