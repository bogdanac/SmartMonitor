using System.ComponentModel;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace SmartMonitor.UI.Extensions
{
    public static class MyExtensions
    {
        private const MetroColorStyle FormStyle = MetroColorStyle.Green;

        public static void SetStyle(this IContainer container, MetroForm ownerForm)
        {
            if (container == null)
            {
                container = new Container();
            }

            var manager = new MetroStyleManager(container);
            manager.Owner = ownerForm;
            container.SetDefaultStyle(ownerForm, FormStyle);
        }

        public static void SetDefaultStyle(this IContainer contr, MetroForm owner, MetroColorStyle style)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Style = style;
            owner.Style = style;
        }

        public static void SetDefaultTheme(this IContainer contr, MetroForm owner, MetroThemeStyle theme)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Theme = theme;
        }

        private static MetroStyleManager FindManager(IContainer contr, MetroForm owner)
        {
            MetroStyleManager manager = null;
            foreach (IComponent item in contr.Components)
            {
                if (((MetroStyleManager)item).Owner == owner)
                {
                    manager = (MetroStyleManager)item;
                }
            }

            return manager;
        }
    }
}