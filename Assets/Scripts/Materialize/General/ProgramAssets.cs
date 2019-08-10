#region

using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

#endregion

namespace Materialize.General
{
    public class ProgramAssets : MonoBehaviour
    {
        public HDRenderPipelineAsset HighQualityAsset;
        public HDRenderPipelineAsset LowQualityAsset;
        public HDRenderPipelineAsset MediumQualityAsset;
        public HDRenderPipelineAsset MinimalQualityAsset;
    }
}