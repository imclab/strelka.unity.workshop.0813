//Eftychios Sartzetakis
//
//Uses 3 Textures
//1. RGB = Diffuse, A = Specular
//2. RGB(A) = Normal map
//3. RGB(A) = Emissive

Shader "Scifi/IllumBumpSpec" {
	Properties {
		_SpecColor ("Specular Color", Color) = (0.5, 0.5, 0.5, 1)
		_Shininess ("Shininess", Range (0.01, 1)) = 0.078125
		_MainTex ("Base (RGB) Gloss (A)", 2D) = "white" {}
		_Illum ("Illumin (A)", 2D) = "white" {}
		_BumpMap ("Normalmap", 2D) = "bump" {}
		}
		SubShader {
			Tags { "RenderType"="Opaque" }
			LOD 400
			CGPROGRAM
			#pragma surface surf BlinnPhong
			
			sampler2D _MainTex;
			sampler2D _BumpMap;
			sampler2D _Illum;
			half _Shininess;
	
			struct Input {
				float2 uv_MainTex;
				float2 uv_Illum;
				float2 uv_BumpMap;
			};
	
		void surf (Input IN, inout SurfaceOutput o) {
			fixed4 tex = tex2D(_MainTex, IN.uv_MainTex);
			
			o.Albedo = tex.rgb;
			o.Emission = tex.rgb * tex2D(_Illum, IN.uv_Illum).rgb;
			o.Gloss = tex.a;
			o.Specular =_Shininess * (tex2D(_MainTex, IN.uv_MainTex).a); 
			o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
		}
		ENDCG
	}
	FallBack "Self-Illumin/Specular"
}
