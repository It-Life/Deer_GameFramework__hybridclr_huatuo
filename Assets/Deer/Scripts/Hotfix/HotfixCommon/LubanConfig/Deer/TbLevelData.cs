//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace cfg.Deer
{
   
public partial class TbLevelData
{
    private readonly Dictionary<int, Deer.LevelData> _dataMap;
    private readonly List<Deer.LevelData> _dataList;
    
    public TbLevelData(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, Deer.LevelData>();
        _dataList = new List<Deer.LevelData>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Deer.LevelData _v;
            _v = Deer.LevelData.DeserializeLevelData(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, Deer.LevelData> DataMap => _dataMap;
    public List<Deer.LevelData> DataList => _dataList;

    public Deer.LevelData GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Deer.LevelData Get(int key) => _dataMap[key];
    public Deer.LevelData this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}