Shader "Blend/BlendMode"
{
    Properties
    {
        _MainColor ("Color", Color) = (1.0, 1.0, 1.0, 0.5)
        _MainTex ("Texture", 2D) = "white" { }
    }
    SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }
        ZWrite Off
        // // Alphablending alpha混合
        // Blend SrcAlpha OneMinusSrcAlpha

        // // Additive 相加混合
        // Blend One One

        // // Soft Additive柔和相加混合
        // Blend One OneMinusDstColor

        // // Multiplicative 相乘混合
        // Blend DstColor Zero

        // // 2x Multiplicative 2倍相乘混合
        // Blend DstColor SrcColor

        Blend  OneMinusDstColor  OneMinusSrcColor







        Pass
        {
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _MainColor;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv) * _MainColor;
                return col;
            }
            ENDCG

        }
    }
}
