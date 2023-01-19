
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;

namespace UGrpc.Pipeline.GrpcPipe.V1
{
    public class MaterialUtils
    {
        public static void UpdateTextures(string source, string diffuse, string channel)
        {
            var materialAsset = AssetDatabase.LoadAssetAtPath(source, typeof(Material)) as Material;
            var diffuseTexture = AssetDatabase.LoadAssetAtPath(diffuse, typeof(Texture2D)) as Texture2D;
            var channelTexture = AssetDatabase.LoadAssetAtPath(channel, typeof(Texture2D)) as Texture2D;

            materialAsset.mainTexture = diffuseTexture;
            materialAsset.SetTexture("_ChannelMap", channelTexture);

        }

        public static void UpdateAlphaAndColor(string source, float alpha, string mainHexColor, string emissionHexColorStr, string rimHexColor)
        {
            var materialAsset = AssetDatabase.LoadAssetAtPath(source, typeof(Material)) as Material;

            var mainColor = SRMaterialUtils.Inst.ConvertHexToColor(hexStr: mainHexColor);
            var emissionColor = SRMaterialUtils.Inst.ConvertHexToColor(hexStr: emissionHexColorStr);
            var rimColor = SRMaterialUtils.Inst.ConvertHexToColor(hexStr: rimHexColor);

            SRMaterialUtils.Inst.UpdateAlphaAndColor(materialAsset, alpha, mainColor, emissionColor, rimColor);
        }
    }
}