using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace HMS.UI.Configs;

public class MaterialThemeConfig
{
    public static void Apply(MaterialForm form)
    {
        var manager = MaterialSkinManager.Instance;
        manager.EnforceBackcolorOnAllComponents = false;
        manager.AddFormToManage(form);
        manager.Theme = MaterialSkinManager.Themes.LIGHT;

        manager.ColorScheme = new MaterialColorScheme(
            MaterialPrimary.Green500,
            MaterialPrimary.Green700,
            MaterialPrimary.Green100,
            MaterialAccent.Pink200,
            MaterialTextShade.WHITE
        );
    }
}
