/// <summary>
/// hahahaUIlib 的根命名空間。
/// </summary>
/// <remarks>
/// <para>這個 library 刻意不放在核心程式路徑中。</para>
/// <para>目的是提供可選用的 UI 輔助能力，同時避免增加耦合、初始化成本與後續維護負擔。</para>
/// <para>提供給未來維護者與 Codex 的約束如下：</para>
/// <list type="number">
/// <item><description>對外功能面要小，且只處理明確、單一目的的需求。</description></item>
/// <item><description>優先使用無狀態 helper 或短生命週期 service，避免全域狀態。</description></item>
/// <item><description>這裡不要引入以 singleton 為核心的協調方式。</description></item>
/// <item><description>不要把這個專案擴張成通用型 plugin 或 DLL 擴充中心。</description></item>
/// <item><description>未來新增 public 型別時，請補上 XML 文件註解，方便呼叫端與後續自動化工具快速理解用途。</description></item>
/// <item><description>若功能屬於高效能敏感或基礎核心能力，應優先放回主專案處理，而不是放在這個可選 library。</description></item>
/// </list>
/// </remarks>
namespace hahahalib
{
    /// <summary>
    /// 目前這個 namespace 保留給輕量、工作導向的 UI 擴充使用。
    /// </summary>
    /// <remarks>
    /// 只有在需求真實存在、而且能夠獨立切分時，才加入具體型別。
    /// </remarks>
}
