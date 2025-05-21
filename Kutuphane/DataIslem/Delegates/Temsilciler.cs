using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataIslem.Delegates
{
    public delegate void BildirimHandler(int Id, string mesaj);
    public delegate bool IslemTamammiHandler(Siparis siparis);

    /// <summary>
    /// Bu delegate sistemin bize hazır sunduğu EventHandler delegatinin aynı imzasını taşıyan bir temsilcilidir
    /// sistemdeki EventHandler temsilicisini anlamak için buraya yazılmıştır.
    /// EventHandler temsilicisi yerine istenirse bu temsilci de kullanılabilir
    /// Burada olay parametrelerinin generik olarak verildiğine ve generik kısıtlama olarak parametrerin EventArgs tipinden türetilmesi
    /// gerektiğine dikkat ediniz.
    /// </summary>
    /// <typeparam name="TOlayParametresi"></typeparam>
    /// <param name="nesne"></param>
    /// <param name="e"></param>
    public delegate void OlayIsleyicisi<TOlayParametresi>(object? nesne,TOlayParametresi? e) where TOlayParametresi:EventArgs;


 
}
