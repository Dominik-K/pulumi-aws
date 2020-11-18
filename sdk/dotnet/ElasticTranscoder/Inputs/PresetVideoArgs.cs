// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticTranscoder.Inputs
{

    public sealed class PresetVideoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The display aspect ratio of the video in the output file. Valid values are: `auto`, `1:1`, `4:3`, `3:2`, `16:9`. (Note; to better control resolution and aspect ratio of output videos, we recommend that you use the values `max_width`, `max_height`, `sizing_policy`, `padding_policy`, and `display_aspect_ratio` instead of `resolution` and `aspect_ratio`.)
        /// </summary>
        [Input("aspectRatio")]
        public Input<string>? AspectRatio { get; set; }

        /// <summary>
        /// The bit rate of the video stream in the output file, in kilobits/second. You can configure variable bit rate or constant bit rate encoding.
        /// </summary>
        [Input("bitRate")]
        public Input<string>? BitRate { get; set; }

        /// <summary>
        /// The video codec for the output file. Valid values are `gif`, `H.264`, `mpeg2`, `vp8`, and `vp9`.
        /// </summary>
        [Input("codec")]
        public Input<string>? Codec { get; set; }

        /// <summary>
        /// The value that Elastic Transcoder adds to the metadata in the output file. If you set DisplayAspectRatio to auto, Elastic Transcoder chooses an aspect ratio that ensures square pixels. If you specify another option, Elastic Transcoder sets that value in the output file.
        /// </summary>
        [Input("displayAspectRatio")]
        public Input<string>? DisplayAspectRatio { get; set; }

        /// <summary>
        /// Whether to use a fixed value for Video:FixedGOP. Not applicable for containers of type gif. Valid values are true and false. Also known as, Fixed Number of Frames Between Keyframes.
        /// </summary>
        [Input("fixedGop")]
        public Input<string>? FixedGop { get; set; }

        /// <summary>
        /// The frames per second for the video stream in the output file. The following values are valid: `auto`, `10`, `15`, `23.97`, `24`, `25`, `29.97`, `30`, `50`, `60`.
        /// </summary>
        [Input("frameRate")]
        public Input<string>? FrameRate { get; set; }

        /// <summary>
        /// The maximum number of frames between key frames. Not applicable for containers of type gif.
        /// </summary>
        [Input("keyframesMaxDist")]
        public Input<string>? KeyframesMaxDist { get; set; }

        /// <summary>
        /// If you specify auto for FrameRate, Elastic Transcoder uses the frame rate of the input video for the frame rate of the output video, up to the maximum frame rate. If you do not specify a MaxFrameRate, Elastic Transcoder will use a default of 30.
        /// </summary>
        [Input("maxFrameRate")]
        public Input<string>? MaxFrameRate { get; set; }

        /// <summary>
        /// The maximum height of the output video in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 96 and 3072, inclusive.
        /// </summary>
        [Input("maxHeight")]
        public Input<string>? MaxHeight { get; set; }

        /// <summary>
        /// The maximum width of the output video in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an even integer between 128 and 4096, inclusive.
        /// </summary>
        [Input("maxWidth")]
        public Input<string>? MaxWidth { get; set; }

        /// <summary>
        /// When you set PaddingPolicy to Pad, Elastic Transcoder might add black bars to the top and bottom and/or left and right sides of the output video to make the total size of the output video match the values that you specified for `max_width` and `max_height`.
        /// </summary>
        [Input("paddingPolicy")]
        public Input<string>? PaddingPolicy { get; set; }

        /// <summary>
        /// The width and height of the video in the output file, in pixels. Valid values are `auto` and `widthxheight`. (see note for `aspect_ratio`)
        /// </summary>
        [Input("resolution")]
        public Input<string>? Resolution { get; set; }

        /// <summary>
        /// A value that controls scaling of the output video. Valid values are: `Fit`, `Fill`, `Stretch`, `Keep`, `ShrinkToFit`, `ShrinkToFill`.
        /// </summary>
        [Input("sizingPolicy")]
        public Input<string>? SizingPolicy { get; set; }

        public PresetVideoArgs()
        {
        }
    }
}
