// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:33420,y:32589,varname:node_4795,prsc:2|diff-1072-RGB,spec-8807-OUT,gloss-8807-OUT,normal-8121-RGB,emission-8482-OUT,alpha-2704-OUT;n:type:ShaderForge.SFN_Tex2d,id:5120,x:32418,y:32322,ptovrint:False,ptlb:Ramp Fire,ptin:_RampFire,varname:node_5120,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dcb375ba5088410498ddb4ce61f48eb6,ntxv:0,isnm:False|UVIN-7388-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:6246,x:30896,y:32453,ptovrint:False,ptlb:Explosion Mask,ptin:_ExplosionMask,varname:node_6246,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:31ddf938f0c213f44873588f38da0cf0,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:2909,x:31189,y:32304,varname:node_2909,prsc:2,tex:31ddf938f0c213f44873588f38da0cf0,ntxv:0,isnm:False|UVIN-2293-OUT,TEX-6246-TEX;n:type:ShaderForge.SFN_Tex2d,id:4163,x:31177,y:32618,varname:node_4163,prsc:2,tex:31ddf938f0c213f44873588f38da0cf0,ntxv:0,isnm:False|TEX-6246-TEX;n:type:ShaderForge.SFN_Append,id:7388,x:32187,y:32347,varname:node_7388,prsc:2|A-4149-OUT,B-8543-OUT;n:type:ShaderForge.SFN_Vector1,id:8543,x:31963,y:32392,varname:node_8543,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:9653,x:32043,y:32827,varname:node_9653,prsc:2|A-3981-OUT,B-6987-OUT,C-3076-A,D-7184-R;n:type:ShaderForge.SFN_Slider,id:6987,x:31603,y:33069,ptovrint:False,ptlb:Opacity Boost,ptin:_OpacityBoost,varname:node_6987,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5,max:10;n:type:ShaderForge.SFN_Clamp01,id:2704,x:32399,y:32864,varname:node_2704,prsc:2|IN-4436-OUT;n:type:ShaderForge.SFN_Add,id:997,x:31390,y:32226,varname:node_997,prsc:2|A-9157-OUT,B-2909-R;n:type:ShaderForge.SFN_VertexColor,id:1337,x:30969,y:32041,varname:node_1337,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9157,x:31189,y:32165,varname:node_9157,prsc:2|A-1337-A,B-2389-OUT;n:type:ShaderForge.SFN_Vector1,id:2389,x:30969,y:32165,varname:node_2389,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Subtract,id:8855,x:31763,y:32081,varname:node_8855,prsc:2|A-8948-OUT,B-116-OUT;n:type:ShaderForge.SFN_VertexColor,id:191,x:31181,y:31959,varname:node_191,prsc:2;n:type:ShaderForge.SFN_OneMinus,id:8138,x:31360,y:31959,varname:node_8138,prsc:2|IN-191-A;n:type:ShaderForge.SFN_Clamp01,id:8948,x:31562,y:32229,varname:node_8948,prsc:2|IN-997-OUT;n:type:ShaderForge.SFN_OneMinus,id:3981,x:31671,y:32642,varname:node_3981,prsc:2|IN-2909-R;n:type:ShaderForge.SFN_Tex2d,id:1072,x:32418,y:32513,ptovrint:False,ptlb:Ramp Smoke,ptin:_RampSmoke,varname:node_1072,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:92765cf9390a9454fb52cd831a9aee88,ntxv:0,isnm:False|UVIN-7032-OUT;n:type:ShaderForge.SFN_VertexColor,id:3076,x:31760,y:33141,varname:node_3076,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8482,x:32628,y:32263,varname:node_8482,prsc:2|A-8861-RGB,B-139-OUT,C-5120-RGB,D-2704-OUT;n:type:ShaderForge.SFN_Slider,id:139,x:32261,y:32220,ptovrint:False,ptlb:Fire Power,ptin:_FirePower,varname:node_139,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:4;n:type:ShaderForge.SFN_Multiply,id:116,x:31542,y:31919,varname:node_116,prsc:2|A-621-OUT,B-8138-OUT;n:type:ShaderForge.SFN_Vector1,id:621,x:31360,y:31894,varname:node_621,prsc:2,v1:2;n:type:ShaderForge.SFN_Clamp01,id:4149,x:31928,y:32081,varname:node_4149,prsc:2|IN-8855-OUT;n:type:ShaderForge.SFN_Append,id:7032,x:32187,y:32478,varname:node_7032,prsc:2|A-8948-OUT,B-8543-OUT;n:type:ShaderForge.SFN_Subtract,id:4436,x:32231,y:32864,varname:node_4436,prsc:2|A-9653-OUT,B-4320-OUT;n:type:ShaderForge.SFN_OneMinus,id:4320,x:32043,y:32972,varname:node_4320,prsc:2|IN-3076-A;n:type:ShaderForge.SFN_Color,id:8861,x:32418,y:32036,ptovrint:False,ptlb:Fire Color,ptin:_FireColor,varname:node_8861,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Tex2d,id:7184,x:31760,y:32882,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7f498ee65d4a1454b8582dff4b81a349,ntxv:0,isnm:False|UVIN-359-OUT;n:type:ShaderForge.SFN_TexCoord,id:5624,x:29822,y:32315,varname:node_5624,prsc:2,uv:0,uaff:True;n:type:ShaderForge.SFN_TexCoord,id:7656,x:30612,y:32122,varname:node_7656,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:2293,x:30889,y:32245,varname:node_2293,prsc:2|A-7656-UVOUT,B-5624-W;n:type:ShaderForge.SFN_Subtract,id:7956,x:30192,y:32644,varname:node_7956,prsc:2|A-5624-W,B-1568-OUT;n:type:ShaderForge.SFN_Vector1,id:1568,x:29991,y:32705,varname:node_1568,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:2723,x:30425,y:32686,varname:node_2723,prsc:2|A-7956-OUT,B-562-OUT;n:type:ShaderForge.SFN_Vector1,id:562,x:30192,y:32771,varname:node_562,prsc:2,v1:4;n:type:ShaderForge.SFN_Ceil,id:2072,x:30597,y:32686,varname:node_2072,prsc:2|IN-2723-OUT;n:type:ShaderForge.SFN_TexCoord,id:550,x:30054,y:32973,varname:node_550,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:6005,x:30258,y:32919,varname:node_6005,prsc:2|A-550-V,B-2072-OUT;n:type:ShaderForge.SFN_Append,id:5506,x:30454,y:33007,varname:node_5506,prsc:2|A-550-U,B-6005-OUT;n:type:ShaderForge.SFN_Vector1,id:8807,x:32991,y:32189,varname:node_8807,prsc:2,v1:0;n:type:ShaderForge.SFN_Tex2d,id:8121,x:32477,y:33361,ptovrint:False,ptlb:Normal Map,ptin:_NormalMap,varname:node_8121,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True|UVIN-2186-OUT;n:type:ShaderForge.SFN_Set,id:1650,x:30617,y:33007,varname:RandomTile,prsc:2|IN-5506-OUT;n:type:ShaderForge.SFN_Get,id:359,x:31544,y:32882,varname:node_359,prsc:2|IN-1650-OUT;n:type:ShaderForge.SFN_Get,id:2186,x:32260,y:33361,varname:node_2186,prsc:2|IN-1650-OUT;proporder:6246-5120-6987-1072-139-8861-7184-8121;pass:END;sub:END;*/

Shader "Sine VFX/ExplosionSpriteLit" {
    Properties {
        _ExplosionMask ("Explosion Mask", 2D) = "white" {}
        _RampFire ("Ramp Fire", 2D) = "white" {}
        _OpacityBoost ("Opacity Boost", Range(0, 10)) = 5
        _RampSmoke ("Ramp Smoke", 2D) = "white" {}
        _FirePower ("Fire Power", Range(0, 4)) = 2
        _FireColor ("Fire Color", Color) = (0.5,0.5,0.5,1)
        _MainTex ("MainTex", 2D) = "white" {}
        _NormalMap ("Normal Map", 2D) = "bump" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _RampFire; uniform float4 _RampFire_ST;
            uniform sampler2D _ExplosionMask; uniform float4 _ExplosionMask_ST;
            uniform float _OpacityBoost;
            uniform sampler2D _RampSmoke; uniform float4 _RampSmoke_ST;
            uniform float _FirePower;
            uniform float4 _FireColor;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float4 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(7)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD8;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float2 RandomTile = float2(i.uv0.r,(i.uv0.g+ceil(((i.uv0.a-1.0)*4.0))));
                float2 node_2186 = RandomTile;
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(node_2186, _NormalMap)));
                float3 normalLocal = _NormalMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float node_8807 = 0.0;
                float gloss = node_8807;
                float perceptualRoughness = 1.0 - node_8807;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = node_8807;
                float specularMonochrome;
                float2 node_2293 = (i.uv0*i.uv0.a);
                float4 node_2909 = tex2D(_ExplosionMask,TRANSFORM_TEX(node_2293, _ExplosionMask));
                float node_8948 = saturate(((i.vertexColor.a*0.5)+node_2909.r));
                float node_8543 = 0.0;
                float2 node_7032 = float2(node_8948,node_8543);
                float4 _RampSmoke_var = tex2D(_RampSmoke,TRANSFORM_TEX(node_7032, _RampSmoke));
                float3 diffuseColor = _RampSmoke_var.rgb; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float2 node_7388 = float2(saturate((node_8948-(2.0*(1.0 - i.vertexColor.a)))),node_8543);
                float4 _RampFire_var = tex2D(_RampFire,TRANSFORM_TEX(node_7388, _RampFire));
                float2 node_359 = RandomTile;
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_359, _MainTex));
                float node_2704 = saturate((((1.0 - node_2909.r)*_OpacityBoost*i.vertexColor.a*_MainTex_var.r)-(1.0 - i.vertexColor.a)));
                float3 emissive = (_FireColor.rgb*_FirePower*_RampFire_var.rgb*node_2704);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,node_2704);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _RampFire; uniform float4 _RampFire_ST;
            uniform sampler2D _ExplosionMask; uniform float4 _ExplosionMask_ST;
            uniform float _OpacityBoost;
            uniform sampler2D _RampSmoke; uniform float4 _RampSmoke_ST;
            uniform float _FirePower;
            uniform float4 _FireColor;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float4 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float2 RandomTile = float2(i.uv0.r,(i.uv0.g+ceil(((i.uv0.a-1.0)*4.0))));
                float2 node_2186 = RandomTile;
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(node_2186, _NormalMap)));
                float3 normalLocal = _NormalMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float node_8807 = 0.0;
                float gloss = node_8807;
                float perceptualRoughness = 1.0 - node_8807;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = node_8807;
                float specularMonochrome;
                float2 node_2293 = (i.uv0*i.uv0.a);
                float4 node_2909 = tex2D(_ExplosionMask,TRANSFORM_TEX(node_2293, _ExplosionMask));
                float node_8948 = saturate(((i.vertexColor.a*0.5)+node_2909.r));
                float node_8543 = 0.0;
                float2 node_7032 = float2(node_8948,node_8543);
                float4 _RampSmoke_var = tex2D(_RampSmoke,TRANSFORM_TEX(node_7032, _RampSmoke));
                float3 diffuseColor = _RampSmoke_var.rgb; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float2 node_359 = RandomTile;
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_359, _MainTex));
                float node_2704 = saturate((((1.0 - node_2909.r)*_OpacityBoost*i.vertexColor.a*_MainTex_var.r)-(1.0 - i.vertexColor.a)));
                fixed4 finalRGBA = fixed4(finalColor * node_2704,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _RampFire; uniform float4 _RampFire_ST;
            uniform sampler2D _ExplosionMask; uniform float4 _ExplosionMask_ST;
            uniform float _OpacityBoost;
            uniform sampler2D _RampSmoke; uniform float4 _RampSmoke_ST;
            uniform float _FirePower;
            uniform float4 _FireColor;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float4 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float2 node_2293 = (i.uv0*i.uv0.a);
                float4 node_2909 = tex2D(_ExplosionMask,TRANSFORM_TEX(node_2293, _ExplosionMask));
                float node_8948 = saturate(((i.vertexColor.a*0.5)+node_2909.r));
                float node_8543 = 0.0;
                float2 node_7388 = float2(saturate((node_8948-(2.0*(1.0 - i.vertexColor.a)))),node_8543);
                float4 _RampFire_var = tex2D(_RampFire,TRANSFORM_TEX(node_7388, _RampFire));
                float2 RandomTile = float2(i.uv0.r,(i.uv0.g+ceil(((i.uv0.a-1.0)*4.0))));
                float2 node_359 = RandomTile;
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_359, _MainTex));
                float node_2704 = saturate((((1.0 - node_2909.r)*_OpacityBoost*i.vertexColor.a*_MainTex_var.r)-(1.0 - i.vertexColor.a)));
                o.Emission = (_FireColor.rgb*_FirePower*_RampFire_var.rgb*node_2704);
                
                float2 node_7032 = float2(node_8948,node_8543);
                float4 _RampSmoke_var = tex2D(_RampSmoke,TRANSFORM_TEX(node_7032, _RampSmoke));
                float3 diffColor = _RampSmoke_var.rgb;
                float specularMonochrome;
                float3 specColor;
                float node_8807 = 0.0;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, node_8807, specColor, specularMonochrome );
                float roughness = 1.0 - node_8807;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
