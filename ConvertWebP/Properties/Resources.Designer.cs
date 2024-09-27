//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertWebP.Properties {
  /// <summary>
  ///   지역화된 문자열 등을 찾기 위한 강력한 형식의 리소스 클래스입니다.
  /// </summary>
  // 이 클래스는 ResGen 또는 Visual Studio와 같은 도구를 통해 StronglyTypedResourceBuilder
  // 클래스에서 자동으로 생성되었습니다.
  // 멤버를 추가하거나 제거하려면 .ResX 파일을 편집한 다음 /str 옵션을 사용하여 ResGen을
  // 다시 실행하거나 VS 프로젝트를 다시 빌드하십시오.
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public class Resources {
    private static global::System.Resources.ResourceManager resourceMan;
    private static global::System.Globalization.CultureInfo resourceCulture;
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resources() {
    }
    /// <summary>
    ///   이 클래스에서 사용하는 캐시된 ResourceManager 인스턴스를 반환합니다.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Resources.ResourceManager ResourceManager {
      get {
        if (object.ReferenceEquals(resourceMan, null)) {
          global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ConvertWebP.Properties.Resources", typeof(Resources).Assembly);
          resourceMan = temp;
        }
        return resourceMan;
      }
    }
    /// <summary>
    ///   이 강력한 형식의 리소스 클래스를 사용하여 모든 리소스 조회에 대해 현재 스레드의 CurrentUICulture 속성을
    ///   재정의합니다.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Globalization.CultureInfo Culture {
      get {
        return resourceCulture;
      }
      set {
        resourceCulture = value;
      }
    }
    /// <summary>
    ///   The following argument lacks the required value:과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrArgNoValue {
      get {
        return ResourceManager.GetString("ErrArgNoValue", resourceCulture);
      }
    }
    /// <summary>
    ///   Failed to process file:과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrFileProcessFailed {
      get {
        return ResourceManager.GetString("ErrFileProcessFailed", resourceCulture);
      }
    }
    /// <summary>
    ///   Invalid path:과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrInvalidPath {
      get {
        return ResourceManager.GetString("ErrInvalidPath", resourceCulture);
      }
    }
    /// <summary>
    ///   The following argument is not valid:과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrInvalidValue {
      get {
        return ResourceManager.GetString("ErrInvalidValue", resourceCulture);
      }
    }
    /// <summary>
    ///   &apos;cwebp.exe&apos; is not found. Aborting.과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrNoCwebp {
      get {
        return ResourceManager.GetString("ErrNoCwebp", resourceCulture);
      }
    }
    /// <summary>
    ///   There is no image file to process.과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrNoFileToProcess {
      get {
        return ResourceManager.GetString("ErrNoFileToProcess", resourceCulture);
      }
    }
    /// <summary>
    ///   &apos;magick.exe&apos; is not found. Aborting.과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrNoMagick {
      get {
        return ResourceManager.GetString("ErrNoMagick", resourceCulture);
      }
    }
    /// <summary>
    ///   The following argument is not a positive integer:과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrNotPositiveInt {
      get {
        return ResourceManager.GetString("ErrNotPositiveInt", resourceCulture);
      }
    }
    /// <summary>
    ///   Error과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrTitle {
      get {
        return ResourceManager.GetString("ErrTitle", resourceCulture);
      }
    }
    /// <summary>
    ///   Too many arguments are provided.과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ErrTooManyArgs {
      get {
        return ResourceManager.GetString("ErrTooManyArgs", resourceCulture);
      }
    }
    /// <summary>
    ///   Usage: cw.exe [-h|--help] [-v|--version] [-w|--width POSITIVE_INTEGER] [-p|--path PATH]
    ///
    ///-h, --help: Show help message (this message).
    ///-v, --version: Show version information.
    ///-w, --width: Width of output WebP Image in pixel. Will be set to 1280 if 0 or negative value is provided.
    ///-p, --path: Path of file/directory to process image(s).과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string HelpContent {
      get {
        return ResourceManager.GetString("HelpContent", resourceCulture);
      }
    }
    /// <summary>
    ///   Help과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string HelpTitle {
      get {
        return ResourceManager.GetString("HelpTitle", resourceCulture);
      }
    }
    /// <summary>
    ///   Information과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string InfoTitle {
      get {
        return ResourceManager.GetString("InfoTitle", resourceCulture);
      }
    }
    /// <summary>
    ///   (아이콘)과(와) 유사한 System.Drawing.Icon 형식의 지역화된 리소스를 찾습니다.
    /// </summary>
    public static System.Drawing.Icon MainIcon {
      get {
        object obj = ResourceManager.GetObject("MainIcon", resourceCulture);
        return ((System.Drawing.Icon)(obj));
      }
    }
    /// <summary>
    ///   Target: 과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string ProgressFormLabelPathPrefix {
      get {
        return ResourceManager.GetString("ProgressFormLabelPathPrefix", resourceCulture);
      }
    }
    /// <summary>
    ///   cw v1.2.0.0과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string VersionContent {
      get {
        return ResourceManager.GetString("VersionContent", resourceCulture);
      }
    }
    /// <summary>
    ///   Version과(와) 유사한 지역화된 문자열을 찾습니다.
    /// </summary>
    public static string VersionTitle {
      get {
        return ResourceManager.GetString("VersionTitle", resourceCulture);
      }
    }
  }
}