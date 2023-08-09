; ModuleID = 'obj\Debug\110\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\110\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [284 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 82
	i64 98382396393917666, ; 1: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 40
	i64 120698629574877762, ; 2: Mono.Android => 0x1accec39cafe242 => 42
	i64 195258733703605363, ; 3: System.Net.Http.Formatting => 0x2b5b2c8a5b22c73 => 52
	i64 196720943101637631, ; 4: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 139
	i64 210515253464952879, ; 5: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 72
	i64 232391251801502327, ; 6: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 104
	i64 295915112840604065, ; 7: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 105
	i64 464346026994987652, ; 8: System.Reactive.dll => 0x671b04057e67284 => 55
	i64 560278790331054453, ; 9: System.Reflection.Primitives => 0x7c6829760de3975 => 17
	i64 634308326490598313, ; 10: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 91
	i64 702024105029695270, ; 11: System.Drawing.Common => 0x9be17343c0e7726 => 125
	i64 720058930071658100, ; 12: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 85
	i64 827515161936339185, ; 13: FreshIOC => 0xb7beca7c97720f1 => 24
	i64 872800313462103108, ; 14: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 81
	i64 940822596282819491, ; 15: System.Transactions => 0xd0e792aa81923a3 => 123
	i64 996343623809489702, ; 16: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 118
	i64 1000557547492888992, ; 17: Mono.Security.dll => 0xde2b1c9cba651a0 => 140
	i64 1010599046655515943, ; 18: System.Reflection.Primitives.dll => 0xe065e7a82401d27 => 17
	i64 1120440138749646132, ; 19: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 120
	i64 1315114680217950157, ; 20: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 67
	i64 1425944114962822056, ; 21: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 21
	i64 1624659445732251991, ; 22: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 65
	i64 1628611045998245443, ; 23: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 93
	i64 1636321030536304333, ; 24: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 86
	i64 1731380447121279447, ; 25: Newtonsoft.Json => 0x18071957e9b889d7 => 46
	i64 1743969030606105336, ; 26: System.Memory.dll => 0x1833d297e88f2af8 => 51
	i64 1795316252682057001, ; 27: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 66
	i64 1836611346387731153, ; 28: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 104
	i64 1865037103900624886, ; 29: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 29
	i64 1875917498431009007, ; 30: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 63
	i64 1981742497975770890, ; 31: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 92
	i64 1986553961460820075, ; 32: Xamarin.CommunityToolkit => 0x1b91a84d8004686b => 114
	i64 2040001226662520565, ; 33: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 141
	i64 2133195048986300728, ; 34: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 46
	i64 2136356949452311481, ; 35: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 97
	i64 2165725771938924357, ; 36: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 70
	i64 2200176636225660136, ; 37: Microsoft.Extensions.Logging.Debug.dll => 0x1e8898fe5d5824e8 => 37
	i64 2262844636196693701, ; 38: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 81
	i64 2284400282711631002, ; 39: System.Web.Services => 0x1fb3d1f42fd4249a => 129
	i64 2287887973817120656, ; 40: System.ComponentModel.DataAnnotations.dll => 0x1fc035fd8d41f790 => 130
	i64 2329709569556905518, ; 41: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 89
	i64 2335503487726329082, ; 42: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 58
	i64 2337758774805907496, ; 43: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 56
	i64 2470498323731680442, ; 44: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 76
	i64 2479423007379663237, ; 45: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 109
	i64 2497223385847772520, ; 46: System.Runtime => 0x22a7eb7046413568 => 57
	i64 2547086958574651984, ; 47: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 62
	i64 2592350477072141967, ; 48: System.Xml.dll => 0x23f9e10627330e8f => 60
	i64 2624866290265602282, ; 49: mscorlib.dll => 0x246d65fbde2db8ea => 43
	i64 2656907746661064104, ; 50: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 34
	i64 2668049510182046531, ; 51: MvvmHelpers => 0x2506d0e4c18e4b43 => 44
	i64 2694427813909235223, ; 52: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 101
	i64 2783046991838674048, ; 53: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 56
	i64 2960931600190307745, ; 54: Xamarin.Forms.Core => 0x2917579a49927da1 => 116
	i64 3017704767998173186, ; 55: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 120
	i64 3284784939149891983, ; 56: Imi.Project.Mobile.Android.dll => 0x2d95e67fa595198f => 0
	i64 3289520064315143713, ; 57: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 88
	i64 3303437397778967116, ; 58: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 64
	i64 3311221304742556517, ; 59: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 54
	i64 3325875462027654285, ; 60: System.Runtime.Numerics => 0x2e27e21c8958b48d => 3
	i64 3493805808809882663, ; 61: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 107
	i64 3494946837667399002, ; 62: Microsoft.Extensions.Configuration => 0x30808ba1c00a455a => 32
	i64 3522470458906976663, ; 63: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 106
	i64 3531994851595924923, ; 64: System.Numerics => 0x31042a9aade235bb => 53
	i64 3571415421602489686, ; 65: System.Runtime.dll => 0x319037675df7e556 => 57
	i64 3638003163729360188, ; 66: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 31
	i64 3647754201059316852, ; 67: System.Xml.ReaderWriter => 0x329f6d1e86145474 => 13
	i64 3655542548057982301, ; 68: Microsoft.Extensions.Configuration.dll => 0x32bb18945e52855d => 32
	i64 3716579019761409177, ; 69: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 70: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 103
	i64 3772598417116884899, ; 71: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 82
	i64 3869221888984012293, ; 72: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 38
	i64 3966267475168208030, ; 73: System.Memory => 0x370b03412596249e => 51
	i64 4006972109285359177, ; 74: System.Xml.XmlDocument => 0x379b9fe74ed9fe49 => 4
	i64 4009997192427317104, ; 75: System.Runtime.Serialization.Primitives => 0x37a65f335cf1a770 => 136
	i64 4187479170553454871, ; 76: System.Linq.Expressions => 0x3a1cea1e912fa117 => 139
	i64 4202567570116092282, ; 77: Newtonsoft.Json.Bson => 0x3a5284f05958a17a => 45
	i64 4205801962323029395, ; 78: System.ComponentModel.TypeConverter => 0x3a5e0299f7e7ad93 => 138
	i64 4523676002271688167, ; 79: MvvmHelpers.dll => 0x3ec7535b4a5cf5e7 => 44
	i64 4525561845656915374, ; 80: System.ServiceModel.Internals => 0x3ece06856b710dae => 131
	i64 4636684751163556186, ; 81: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 111
	i64 4645756877833507374, ; 82: Imi.Project.Mobile.dll => 0x40790b442018122e => 27
	i64 4657212095206026001, ; 83: Microsoft.Extensions.Http.dll => 0x40a1bdb9c2686b11 => 35
	i64 4743821336939966868, ; 84: System.ComponentModel.Annotations => 0x41d5705f4239b194 => 2
	i64 4782108999019072045, ; 85: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 69
	i64 4794310189461587505, ; 86: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 62
	i64 4795410492532947900, ; 87: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 106
	i64 4984589564328971462, ; 88: FluentValidation => 0x452cd1cc9cf28cc6 => 22
	i64 5142919913060024034, ; 89: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 117
	i64 5203618020066742981, ; 90: Xamarin.Essentials => 0x4836f704f0e652c5 => 115
	i64 5205316157927637098, ; 91: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 95
	i64 5348796042099802469, ; 92: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 96
	i64 5359521160085360696, ; 93: FreshIOC.dll => 0x4a60d8196113d038 => 24
	i64 5376510917114486089, ; 94: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 109
	i64 5404556524862317797, ; 95: FluentValidation.dll => 0x4b00d78658f024e5 => 22
	i64 5408338804355907810, ; 96: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 108
	i64 5446034149219586269, ; 97: System.Diagnostics.Debug => 0x4b94333452e150dd => 9
	i64 5451019430259338467, ; 98: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 75
	i64 5507995362134886206, ; 99: System.Core.dll => 0x4c705499688c873e => 48
	i64 5633126816028165141, ; 100: FreshMvvm => 0x4e2ce2fe5c160415 => 25
	i64 5692067934154308417, ; 101: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 113
	i64 5757522595884336624, ; 102: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 73
	i64 5814345312393086621, ; 103: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 101
	i64 5896680224035167651, ; 104: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 90
	i64 6085203216496545422, ; 105: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 118
	i64 6086316965293125504, ; 106: FormsViewGroup.dll => 0x5476f10882baef80 => 23
	i64 6222399776351216807, ; 107: System.Text.Json.dll => 0x565a67a0ffe264a7 => 59
	i64 6319713645133255417, ; 108: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 91
	i64 6401687960814735282, ; 109: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 89
	i64 6504860066809920875, ; 110: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 70
	i64 6548213210057960872, ; 111: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 79
	i64 6560151584539558821, ; 112: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 39
	i64 6591024623626361694, ; 113: System.Web.Services.dll => 0x5b7805f9751a1b5e => 129
	i64 6659513131007730089, ; 114: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 85
	i64 6814185388980153342, ; 115: System.Xml.XDocument.dll => 0x5e90d98217d1abfe => 5
	i64 6876862101832370452, ; 116: System.Xml.Linq => 0x5f6f85a57d108914 => 61
	i64 6894844156784520562, ; 117: System.Numerics.Vectors => 0x5faf683aead1ad72 => 54
	i64 7036436454368433159, ; 118: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 87
	i64 7103753931438454322, ; 119: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 84
	i64 7129514256229348874, ; 120: Imi.Project.Mobile.Android => 0x62f11f7137a2360a => 0
	i64 7141577505875122296, ; 121: System.Runtime.InteropServices.WindowsRuntime.dll => 0x631bfae7659b5878 => 19
	i64 7270811800166795866, ; 122: System.Linq => 0x64e71ccf51a90a5a => 135
	i64 7338192458477945005, ; 123: System.Reflection => 0x65d67f295d0740ad => 137
	i64 7377312882064240630, ; 124: System.ComponentModel.TypeConverter.dll => 0x66617afac45a2ff6 => 138
	i64 7488575175965059935, ; 125: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 61
	i64 7489048572193775167, ; 126: System.ObjectModel => 0x67ee71ff6b419e3f => 12
	i64 7602111570124318452, ; 127: System.Reactive => 0x698020320025a6f4 => 55
	i64 7635363394907363464, ; 128: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 116
	i64 7637365915383206639, ; 129: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 115
	i64 7654504624184590948, ; 130: System.Net.Http => 0x6a3a4366801b8264 => 20
	i64 7735176074855944702, ; 131: Microsoft.CSharp => 0x6b58dda848e391fe => 30
	i64 7820441508502274321, ; 132: System.Data => 0x6c87ca1e14ff8111 => 122
	i64 7836164640616011524, ; 133: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 65
	i64 8044118961405839122, ; 134: System.ComponentModel.Composition => 0x6fa2739369944712 => 128
	i64 8064050204834738623, ; 135: System.Collections.dll => 0x6fe942efa61731bf => 6
	i64 8083354569033831015, ; 136: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 88
	i64 8087206902342787202, ; 137: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 49
	i64 8103644804370223335, ; 138: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 124
	i64 8113615946733131500, ; 139: System.Reflection.Extensions => 0x70995ab73cf916ec => 16
	i64 8167236081217502503, ; 140: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 28
	i64 8185542183669246576, ; 141: System.Collections => 0x7198e33f4794aa70 => 6
	i64 8290740647658429042, ; 142: System.Runtime.Extensions => 0x730ea0b15c929a72 => 134
	i64 8318905602908530212, ; 143: System.ComponentModel.DataAnnotations => 0x7372b092055ea624 => 130
	i64 8398329775253868912, ; 144: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 74
	i64 8400357532724379117, ; 145: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 100
	i64 8601935802264776013, ; 146: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 108
	i64 8626175481042262068, ; 147: Java.Interop => 0x77b654e585b55834 => 28
	i64 8638972117149407195, ; 148: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 30
	i64 8639588376636138208, ; 149: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 99
	i64 8684531736582871431, ; 150: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 127
	i64 8725526185868997716, ; 151: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 49
	i64 8849523176203181611, ; 152: Howest.Prog.Xamarin.UriSourceExtensions => 0x7acfd271252d5e2b => 26
	i64 8941376889969657626, ; 153: System.Xml.XDocument => 0x7c1626e87187471a => 5
	i64 9312692141327339315, ; 154: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 113
	i64 9324707631942237306, ; 155: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 66
	i64 9584643793929893533, ; 156: System.IO.dll => 0x85037ebfbbd7f69d => 132
	i64 9659729154652888475, ; 157: System.Text.RegularExpressions => 0x860e407c9991dd9b => 133
	i64 9662334977499516867, ; 158: System.Numerics.dll => 0x8617827802b0cfc3 => 53
	i64 9678050649315576968, ; 159: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 76
	i64 9711637524876806384, ; 160: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 96
	i64 9808709177481450983, ; 161: Mono.Android.dll => 0x881f890734e555e7 => 42
	i64 9825649861376906464, ; 162: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 73
	i64 9834056768316610435, ; 163: System.Transactions.dll => 0x8879968718899783 => 123
	i64 9994308163963284983, ; 164: Newtonsoft.Json.Bson.dll => 0x8ab2ea52b0d16df7 => 45
	i64 9998632235833408227, ; 165: Mono.Security => 0x8ac2470b209ebae3 => 140
	i64 10017511394021241210, ; 166: Microsoft.Extensions.Logging.Debug => 0x8b055989ae10717a => 37
	i64 10038780035334861115, ; 167: System.Net.Http.dll => 0x8b50e941206af13b => 20
	i64 10229024438826829339, ; 168: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 79
	i64 10360651442923773544, ; 169: System.Text.Encoding => 0x8fc86d98211c1e68 => 14
	i64 10376576884623852283, ; 170: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 107
	i64 10430153318873392755, ; 171: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 77
	i64 10447083246144586668, ; 172: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 29
	i64 10566960649245365243, ; 173: System.Globalization.dll => 0x92a562b96dcd13fb => 7
	i64 10714184849103829812, ; 174: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 134
	i64 10847732767863316357, ; 175: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 67
	i64 10943211539042655480, ; 176: FreshMvvm.dll => 0x97de18ea4697dcf8 => 25
	i64 11002576679268595294, ; 177: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 36
	i64 11023048688141570732, ; 178: System.Core => 0x98f9bc61168392ac => 48
	i64 11037814507248023548, ; 179: System.Xml => 0x992e31d0412bf7fc => 60
	i64 11122995063473561350, ; 180: Xamarin.CommunityToolkit.dll => 0x9a5cd113fcc3df06 => 114
	i64 11162124722117608902, ; 181: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 112
	i64 11226290749488709958, ; 182: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 39
	i64 11340910727871153756, ; 183: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 78
	i64 11392833485892708388, ; 184: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 102
	i64 11529969570048099689, ; 185: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 112
	i64 11530571088791430846, ; 186: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 38
	i64 11578238080964724296, ; 187: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 87
	i64 11580057168383206117, ; 188: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 63
	i64 11597940890313164233, ; 189: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 190: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 84
	i64 11743665907891708234, ; 191: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 8
	i64 12102847907131387746, ; 192: System.Buffers => 0xa7f5f40c43256f62 => 47
	i64 12123043025855404482, ; 193: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 16
	i64 12137774235383566651, ; 194: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 110
	i64 12145679461940342714, ; 195: System.Text.Json => 0xa88e1f1ebcb62fba => 59
	i64 12201331334810686224, ; 196: System.Runtime.Serialization.Primitives.dll => 0xa953d6341e3bd310 => 136
	i64 12451044538927396471, ; 197: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 83
	i64 12466513435562512481, ; 198: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 94
	i64 12487638416075308985, ; 199: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 80
	i64 12538491095302438457, ; 200: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 71
	i64 12550732019250633519, ; 201: System.IO.Compression => 0xae2d28465e8e1b2f => 126
	i64 12700543734426720211, ; 202: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 72
	i64 12708238894395270091, ; 203: System.IO => 0xb05cbbf17d3ba3cb => 132
	i64 12708922737231849740, ; 204: System.Text.Encoding.Extensions => 0xb05f29e50e96e90c => 18
	i64 12843321153144804894, ; 205: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 40
	i64 12963446364377008305, ; 206: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 125
	i64 13068258254871114833, ; 207: System.Runtime.Serialization.Formatters.dll => 0xb55bc7a4eaa8b451 => 11
	i64 13370592475155966277, ; 208: System.Runtime.Serialization => 0xb98de304062ea945 => 21
	i64 13401370062847626945, ; 209: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 110
	i64 13404347523447273790, ; 210: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 74
	i64 13454009404024712428, ; 211: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 121
	i64 13491513212026656886, ; 212: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 68
	i64 13572454107664307259, ; 213: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 103
	i64 13619343573712272001, ; 214: Howest.Prog.Xamarin.UriSourceExtensions.dll => 0xbd01a0d2691e7a81 => 26
	i64 13647894001087880694, ; 215: System.Data.dll => 0xbd670f48cb071df6 => 122
	i64 13713329104121190199, ; 216: System.Dynamic.Runtime => 0xbe4f8829f32b5737 => 10
	i64 13959074834287824816, ; 217: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 83
	i64 13967638549803255703, ; 218: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 117
	i64 14124974489674258913, ; 219: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 71
	i64 14125464355221830302, ; 220: System.Threading.dll => 0xc407bafdbc707a9e => 15
	i64 14172845254133543601, ; 221: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 97
	i64 14254574811015963973, ; 222: System.Text.Encoding.Extensions.dll => 0xc5d26c4442d66545 => 18
	i64 14261073672896646636, ; 223: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 102
	i64 14327695147300244862, ; 224: System.Reflection.dll => 0xc6d632d338eb4d7e => 137
	i64 14486659737292545672, ; 225: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 90
	i64 14551742072151931844, ; 226: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 58
	i64 14622043554576106986, ; 227: System.Runtime.Serialization.Formatters => 0xcaebef2458cc85ea => 11
	i64 14644440854989303794, ; 228: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 95
	i64 14669215534098758659, ; 229: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 34
	i64 14792063746108907174, ; 230: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 121
	i64 14852515768018889994, ; 231: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 78
	i64 14954917835170835695, ; 232: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 33
	i64 14987728460634540364, ; 233: System.IO.Compression.dll => 0xcfff1ba06622494c => 126
	i64 14988210264188246988, ; 234: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 80
	i64 15076659072870671916, ; 235: System.ObjectModel.dll => 0xd13b0d8c1620662c => 12
	i64 15133485256822086103, ; 236: System.Linq.dll => 0xd204f0a9127dd9d7 => 135
	i64 15227001540531775957, ; 237: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 31
	i64 15234786388537674379, ; 238: System.Dynamic.Runtime.dll => 0xd36cd580c5be8a8b => 10
	i64 15370334346939861994, ; 239: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 77
	i64 15391712275433856905, ; 240: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 33
	i64 15526743539506359484, ; 241: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 14
	i64 15582737692548360875, ; 242: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 93
	i64 15609085926864131306, ; 243: System.dll => 0xd89e9cf3334914ea => 50
	i64 15661133872274321916, ; 244: System.Xml.ReaderWriter.dll => 0xd9578647d4bfb1fc => 13
	i64 15777549416145007739, ; 245: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 105
	i64 15810740023422282496, ; 246: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 119
	i64 15817206913877585035, ; 247: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 8
	i64 15963349826457351533, ; 248: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 141
	i64 16154507427712707110, ; 249: System => 0xe03056ea4e39aa26 => 50
	i64 16321164108206115771, ; 250: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 36
	i64 16558262036769511634, ; 251: Microsoft.Extensions.Http => 0xe5cac397cf7b98d2 => 35
	i64 16565028646146589191, ; 252: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 128
	i64 16621146507174665210, ; 253: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 75
	i64 16677317093839702854, ; 254: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 100
	i64 16822611501064131242, ; 255: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 124
	i64 16833383113903931215, ; 256: mscorlib => 0xe99c30c1484d7f4f => 43
	i64 16866861824412579935, ; 257: System.Runtime.InteropServices.WindowsRuntime => 0xea132176ffb5785f => 19
	i64 16890310621557459193, ; 258: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 133
	i64 17024911836938395553, ; 259: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 64
	i64 17031351772568316411, ; 260: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 98
	i64 17037200463775726619, ; 261: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 86
	i64 17126545051278881272, ; 262: Microsoft.Net.Http.Headers.dll => 0xedadb5fbdb33b1f8 => 41
	i64 17187273293601214786, ; 263: System.ComponentModel.Annotations.dll => 0xee8575ff9aa89142 => 2
	i64 17544493274320527064, ; 264: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 69
	i64 17627500474728259406, ; 265: System.Globalization => 0xf4a176498a351f4e => 7
	i64 17685921127322830888, ; 266: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 9
	i64 17704177640604968747, ; 267: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 94
	i64 17710060891934109755, ; 268: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 92
	i64 17727188866493996799, ; 269: System.Net.Http.Formatting.dll => 0xf603a059f5a25eff => 52
	i64 17777860260071588075, ; 270: System.Runtime.Numerics.dll => 0xf6b7a5b72419c0eb => 3
	i64 17838668724098252521, ; 271: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 47
	i64 17882897186074144999, ; 272: FormsViewGroup => 0xf82cd03e3ac830e7 => 23
	i64 17892495832318972303, ; 273: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 119
	i64 17911643751311784505, ; 274: Microsoft.Net.Http.Headers => 0xf892f1178448ba39 => 41
	i64 17928294245072900555, ; 275: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 127
	i64 17992315986609351877, ; 276: System.Xml.XmlDocument.dll => 0xf9b18c0ffc6eacc5 => 4
	i64 18025913125965088385, ; 277: System.Threading => 0xfa28e87b91334681 => 15
	i64 18116111925905154859, ; 278: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 68
	i64 18121036031235206392, ; 279: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 98
	i64 18129453464017766560, ; 280: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 131
	i64 18305135509493619199, ; 281: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 99
	i64 18355722495993441458, ; 282: Imi.Project.Mobile => 0xfebca05b7955ecb2 => 27
	i64 18380184030268848184 ; 283: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 111
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [284 x i32] [
	i32 82, i32 40, i32 42, i32 52, i32 139, i32 72, i32 104, i32 105, ; 0..7
	i32 55, i32 17, i32 91, i32 125, i32 85, i32 24, i32 81, i32 123, ; 8..15
	i32 118, i32 140, i32 17, i32 120, i32 67, i32 21, i32 65, i32 93, ; 16..23
	i32 86, i32 46, i32 51, i32 66, i32 104, i32 29, i32 63, i32 92, ; 24..31
	i32 114, i32 141, i32 46, i32 97, i32 70, i32 37, i32 81, i32 129, ; 32..39
	i32 130, i32 89, i32 58, i32 56, i32 76, i32 109, i32 57, i32 62, ; 40..47
	i32 60, i32 43, i32 34, i32 44, i32 101, i32 56, i32 116, i32 120, ; 48..55
	i32 0, i32 88, i32 64, i32 54, i32 3, i32 107, i32 32, i32 106, ; 56..63
	i32 53, i32 57, i32 31, i32 13, i32 32, i32 1, i32 103, i32 82, ; 64..71
	i32 38, i32 51, i32 4, i32 136, i32 139, i32 45, i32 138, i32 44, ; 72..79
	i32 131, i32 111, i32 27, i32 35, i32 2, i32 69, i32 62, i32 106, ; 80..87
	i32 22, i32 117, i32 115, i32 95, i32 96, i32 24, i32 109, i32 22, ; 88..95
	i32 108, i32 9, i32 75, i32 48, i32 25, i32 113, i32 73, i32 101, ; 96..103
	i32 90, i32 118, i32 23, i32 59, i32 91, i32 89, i32 70, i32 79, ; 104..111
	i32 39, i32 129, i32 85, i32 5, i32 61, i32 54, i32 87, i32 84, ; 112..119
	i32 0, i32 19, i32 135, i32 137, i32 138, i32 61, i32 12, i32 55, ; 120..127
	i32 116, i32 115, i32 20, i32 30, i32 122, i32 65, i32 128, i32 6, ; 128..135
	i32 88, i32 49, i32 124, i32 16, i32 28, i32 6, i32 134, i32 130, ; 136..143
	i32 74, i32 100, i32 108, i32 28, i32 30, i32 99, i32 127, i32 49, ; 144..151
	i32 26, i32 5, i32 113, i32 66, i32 132, i32 133, i32 53, i32 76, ; 152..159
	i32 96, i32 42, i32 73, i32 123, i32 45, i32 140, i32 37, i32 20, ; 160..167
	i32 79, i32 14, i32 107, i32 77, i32 29, i32 7, i32 134, i32 67, ; 168..175
	i32 25, i32 36, i32 48, i32 60, i32 114, i32 112, i32 39, i32 78, ; 176..183
	i32 102, i32 112, i32 38, i32 87, i32 63, i32 1, i32 84, i32 8, ; 184..191
	i32 47, i32 16, i32 110, i32 59, i32 136, i32 83, i32 94, i32 80, ; 192..199
	i32 71, i32 126, i32 72, i32 132, i32 18, i32 40, i32 125, i32 11, ; 200..207
	i32 21, i32 110, i32 74, i32 121, i32 68, i32 103, i32 26, i32 122, ; 208..215
	i32 10, i32 83, i32 117, i32 71, i32 15, i32 97, i32 18, i32 102, ; 216..223
	i32 137, i32 90, i32 58, i32 11, i32 95, i32 34, i32 121, i32 78, ; 224..231
	i32 33, i32 126, i32 80, i32 12, i32 135, i32 31, i32 10, i32 77, ; 232..239
	i32 33, i32 14, i32 93, i32 50, i32 13, i32 105, i32 119, i32 8, ; 240..247
	i32 141, i32 50, i32 36, i32 35, i32 128, i32 75, i32 100, i32 124, ; 248..255
	i32 43, i32 19, i32 133, i32 64, i32 98, i32 86, i32 41, i32 2, ; 256..263
	i32 69, i32 7, i32 9, i32 94, i32 92, i32 52, i32 3, i32 47, ; 264..271
	i32 23, i32 119, i32 41, i32 127, i32 4, i32 15, i32 68, i32 98, ; 272..279
	i32 131, i32 99, i32 27, i32 111 ; 280..283
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
