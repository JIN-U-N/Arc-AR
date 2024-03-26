Shader "Custom/NewSurfaceShader"
{
    Properties {
        _Color ("Main Color", Color) = (1,1,1,1)
        _Smoothness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _Cull ("Cull Mode", Range(0,2)) = 2
        _Alpha ("Alpha", Range(0,1)) = 1.0
    }
    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" }
        Pass {
            Name "UniversalForward"
            Tags { "LightMode" = "UniversalForward" }
            
            Cull [_Cull]
            
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            #include "UnityCG.cginc"
            
            struct appdata {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
            
            struct v2f {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
            
            float4 _Color;
            float _Smoothness;
            float _Metallic;
            float _Alpha;
            
            v2f vert(appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
            
            half4 frag(v2f i) : SV_Target {
                half4 c = _Color;
                c.a *= _Alpha;
                return c;
            }
            ENDHLSL
        }
    }
    FallBack "Diffuse"
}