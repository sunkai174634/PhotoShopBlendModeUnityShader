using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;

public class BlendModeGUI : ShaderGUI
{
    private Material mat;

    enum BlendModeChoose
    {
        正常_Normal,
        透明混合_Alphablend,
        变暗_Darken,
        正片叠底_Multiply,
        颜色加深_ColorBurn,
        线性加深_LinearBurn,
        深色_DarkerColor,
        变亮_Lighten,
        滤色_Screen,
        颜色减淡_ColorDodge,
        线性减淡_LinearDodge,
        浅色_LighterColor,
        叠加_Overlay,
        柔光_SoftLight,
        强光_HardLight,
        亮光_VividLight,
        线性光_LinearLight,
        点光_PinLight,
        实色混合_HardMix,
        差值_Difference,
        排除_Exclusion,
        减去_Subtract,
        划分_Divide,
        色相_Hue,
        饱和度_Saturation,
        颜色_Color,
        明度_Luminosity
    }

    private MaterialProperty ModeID;
    private MaterialProperty ModeChooseProps;
    string[] MateritalChoosenames = System.Enum.GetNames(typeof(BlendModeChoose));

    private MaterialProperty DstColorProps;
    private MaterialProperty DstTextureProps;
    private MaterialProperty SrcColorProps;
    private MaterialProperty SrcTextureProps;

    public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties)
    {
        // base.OnGUI(materialEditor, properties);
        EditorGUILayout.BeginVertical(new GUIStyle("U2D.createRect"));
        EditorGUILayout.Space(10);
        ModeChooseProps = FindProperty("_IDChoose", properties);
        ModeID = FindProperty("_ModeID", properties);
        ModeChooseProps.floatValue = EditorGUILayout.Popup(
            "BlendModeChoose", (int) ModeChooseProps.floatValue,
            MateritalChoosenames);
        switch (ModeChooseProps.floatValue)
        {
            case 0:
                ModeID.floatValue = 0;
                break;
            case 1:
                ModeID.floatValue = 1;
                break;
            case 2:
                ModeID.floatValue = 2;
                break;
            case 3:
                ModeID.floatValue = 3;
                break;
            case 4:
                ModeID.floatValue = 4;
                break;
            case 5:
                ModeID.floatValue = 5;
                break;
            case 6:
                ModeID.floatValue = 6;
                break;
            case 7:
                ModeID.floatValue = 7;
                break;
            case 8:
                ModeID.floatValue = 8;
                break;
            case 9:
                ModeID.floatValue = 9;
                break;
            case 10:
                ModeID.floatValue = 10;
                break;
            case 11:
                ModeID.floatValue = 11;
                break;
            case 12:
                ModeID.floatValue = 12;
                break;
            case 13:
                ModeID.floatValue = 13;
                break;
            case 14:
                ModeID.floatValue = 14;
                break;
            case 15:
                ModeID.floatValue = 15;
                break;
            case 16:
                ModeID.floatValue = 16;
                break;
            case 17:
                ModeID.floatValue = 17;
                break;
            case 18:
                ModeID.floatValue = 18;
                break;
            case 19:
                ModeID.floatValue = 19;
                break;

            case 20:
                ModeID.floatValue = 20;
                break;
            case 21:
                ModeID.floatValue = 21;
                break;
            case 22:
                ModeID.floatValue = 22;
                break;
            case 23:
                ModeID.floatValue = 23;
                break;
            case 24:
                ModeID.floatValue = 24;
                break;
            case 25:
                ModeID.floatValue = 25;
                break;
            case 26:
                ModeID.floatValue = 26;
                break;
        }

        EditorGUILayout.Space(10);
        EditorGUILayout.EndVertical();
        EditorGUILayout.Space(30);
        EditorGUILayout.BeginVertical(EditorStyles.helpBox);
        EditorGUILayout.Space(10);
        DstColorProps = FindProperty("_Color1", properties);
        materialEditor.ColorProperty(DstColorProps, "DstColor");
        DstTextureProps = FindProperty("_MainTex1", properties);
        materialEditor.TextureProperty(DstTextureProps, "DstTexture");
        EditorGUILayout.Space(20);
        SrcColorProps = FindProperty("_Color2", properties);
        materialEditor.ColorProperty(SrcColorProps, "SrcColor");
        SrcTextureProps = FindProperty("_MainTex2", properties);
        materialEditor.TextureProperty(SrcTextureProps, "SrcTexture");
        EditorGUILayout.Space(10);
        EditorGUILayout.EndVertical();
    }
}