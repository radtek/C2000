﻿using System.ComponentModel;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialLabel : Label, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            ForeColor = SkinManager.GetSecondaryTextColor();
            Font = SkinManager.ROBOTO_MEDIUM_10;

            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetSecondaryTextColor();
        }
    }
}
