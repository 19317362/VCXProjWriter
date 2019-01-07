using System;
using System.Collections.Generic;

namespace VcxProjLib
{
    public class VCXProject
    {
        struct sToolsVersion {
            public UInt16 Major;
            public UInt16 Minor;
        }

        /* Properties */

/*
  <PropertyGroup Label="Globals">
    <ProjectGuid>{FFF93A94-856E-4F34-80E4-D5E2FB32F955}</ProjectGuid>
    <Keyword>Linux</Keyword>
    <RootNamespace>arp</RootNamespace>
    <MinimumVisualStudioVersion>15.0</MinimumVisualStudioVersion>
    <ApplicationType>Linux</ApplicationType>
    <ApplicationTypeRevision>1.0</ApplicationTypeRevision>
    <TargetLinuxPlatform>Generic</TargetLinuxPlatform>
    <LinuxProjectType>{FC1A4D80-50E9-41DA-9192-61C0DBAA00D2}</LinuxProjectType>
    <ProjectName>iss_future</ProjectName>
  </PropertyGroup>
  <Import Project="$(VCTargetsPath)\Microsoft.Cpp.Default.props" />
  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Devel|x86'" Label="Configuration">
    <UseDebugLibraries>true</UseDebugLibraries>
    <ConfigurationType>Makefile</ConfigurationType>
    <RemoteRootDir>/local/store/git/realtek_iss</RemoteRootDir>
  </PropertyGroup>
  <Import Project="$(VCTargetsPath)\Microsoft.Cpp.props" />
  <ImportGroup Label="ExtensionSettings" />
  <ImportGroup Label="Shared" />
  <ImportGroup Label="PropertySheets" />
  <PropertyGroup Label="UserMacros" />
  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Devel|x86'">
    <RemoteBuildCommandLine>source /local/store/rtl_sdk.sh &amp;&amp; ./mybuild.sh --wm</RemoteBuildCommandLine>
    <RemoteCleanCommandLine>source /local/store/rtl_sdk.sh &amp;&amp; ./mybuild.sh -C</RemoteCleanCommandLine>
    <RemoteProjectDir>/local/store/git/realtek_iss</RemoteProjectDir>
    <LocalRemoteCopySources>true</LocalRemoteCopySources>
    <BuildCommandLine>echo "Build; appendix is 2&gt;&amp;1 | sed -e 's/\//\\/g' -e 's/\\local\\store\\git/D:\\VMShare\\ubu14x86r2/g'"</BuildCommandLine>
    <SourcesToCopyRemotelyOverride />
*/

        readonly sToolsVersion ToolsVersion = new sToolsVersion { Major = 15, Minor = 0 };
        
        /* GROUP: propertygroup label globals */
        static readonly String LinuxProjectType = "{FC1A4D80-50E9-41DA-9192-61C0DBAA00D2}";
        readonly String Keyword = "Linux";
        readonly String RootNamespace = "";
        readonly String MinimumVisualStudioVersion = "15.0";
        readonly String ApplicationType = "Linux";
        readonly String ApplicationTypeRevision = "1.0";
        readonly String TargetLinuxPlatform = "Generic";
        /* these are editable */
        String ProjectName;
        Guid ProjectGuid;

        /* GROUP: ungroupped imports */
        String[] ImportMSProjectProps =
        {
            /* preserve order pls */
            @"$(VCTargetsPath)\Microsoft.Cpp.Default.props"
          , @"$(VCTargetsPath)\Microsoft.Cpp.props"
        };
        String[] ImportMSProjectGroups =
        {
            "ExtensionSettings"
          , "Shared"
          , "PropertySheets"
        };

        /* itemgroup label projectconfigurations */
        List<VCXProjectConfiguration> configurations;

        /* itemgroup */
        List<String> sources;
        /* itemgroup */
        List<String> includes;
        /* itemgroup */
        List<String> auxillaries;

        public VCXProject()
        {
            this.ProjectGuid = Guid.NewGuid();
        }
    }
}
