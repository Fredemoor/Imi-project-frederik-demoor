; ModuleID = 'obj\Debug\110\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\110\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [284 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 91
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 121
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 46
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 116
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 105
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 105
	i32 159306688, ; 6: System.ComponentModel.Annotations => 0x97ed3c0 => 2
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 72
	i32 182336117, ; 8: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 106
	i32 209399409, ; 9: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 70
	i32 220171995, ; 10: System.Diagnostics.Debug => 0xd1f8edb => 9
	i32 230216969, ; 11: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 86
	i32 230752869, ; 12: Microsoft.CSharp.dll => 0xdc10265 => 30
	i32 231814094, ; 13: System.Globalization => 0xdd133ce => 7
	i32 232815796, ; 14: System.Web.Services => 0xde07cb4 => 129
	i32 261689757, ; 15: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 75
	i32 278686392, ; 16: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 90
	i32 280482487, ; 17: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 84
	i32 291275502, ; 18: Microsoft.Extensions.Http.dll => 0x115c82ee => 35
	i32 318968648, ; 19: Xamarin.AndroidX.Activity.dll => 0x13031348 => 62
	i32 321597661, ; 20: System.Numerics => 0x132b30dd => 53
	i32 342366114, ; 21: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 88
	i32 385762202, ; 22: System.Memory.dll => 0x16fe439a => 51
	i32 441335492, ; 23: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 74
	i32 442521989, ; 24: Xamarin.Essentials => 0x1a605985 => 115
	i32 442565967, ; 25: System.Collections => 0x1a61054f => 6
	i32 450948140, ; 26: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 83
	i32 459347974, ; 27: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 136
	i32 465846621, ; 28: mscorlib => 0x1bc4415d => 43
	i32 469710990, ; 29: System.dll => 0x1bff388e => 50
	i32 476646585, ; 30: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 84
	i32 486930444, ; 31: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 95
	i32 498788369, ; 32: System.ObjectModel => 0x1dbae811 => 12
	i32 513247710, ; 33: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 40
	i32 526420162, ; 34: System.Transactions.dll => 0x1f6088c2 => 123
	i32 539058512, ; 35: Microsoft.Extensions.Logging => 0x20216150 => 38
	i32 545304856, ; 36: System.Runtime.Extensions => 0x2080b118 => 134
	i32 548916678, ; 37: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 29
	i32 605376203, ; 38: System.IO.Compression.FileSystem => 0x24154ecb => 127
	i32 610194910, ; 39: System.Reactive.dll => 0x245ed5de => 55
	i32 627609679, ; 40: Xamarin.AndroidX.CustomView => 0x2568904f => 79
	i32 662205335, ; 41: System.Text.Encodings.Web.dll => 0x27787397 => 58
	i32 663517072, ; 42: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 111
	i32 666292255, ; 43: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 67
	i32 690569205, ; 44: System.Xml.Linq.dll => 0x29293ff5 => 61
	i32 775507847, ; 45: System.IO.Compression => 0x2e394f87 => 126
	i32 789151979, ; 46: Microsoft.Extensions.Options => 0x2f0980eb => 39
	i32 809851609, ; 47: System.Drawing.Common.dll => 0x30455ad9 => 125
	i32 835661280, ; 48: MvvmHelpers.dll => 0x31cf2de0 => 44
	i32 843511501, ; 49: Xamarin.AndroidX.Print => 0x3246f6cd => 102
	i32 877678880, ; 50: System.Globalization.dll => 0x34505120 => 7
	i32 928116545, ; 51: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 121
	i32 955402788, ; 52: Newtonsoft.Json => 0x38f24a24 => 46
	i32 967690846, ; 53: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 88
	i32 974778368, ; 54: FormsViewGroup.dll => 0x3a19f000 => 23
	i32 975874589, ; 55: System.Xml.XDocument => 0x3a2aaa1d => 5
	i32 992768348, ; 56: System.Collections.dll => 0x3b2c715c => 6
	i32 1012816738, ; 57: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 104
	i32 1028951442, ; 58: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 33
	i32 1035644815, ; 59: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 66
	i32 1042160112, ; 60: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 118
	i32 1044663988, ; 61: System.Linq.Expressions.dll => 0x3e444eb4 => 139
	i32 1052210849, ; 62: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 92
	i32 1082857460, ; 63: System.ComponentModel.TypeConverter => 0x408b17f4 => 138
	i32 1098259244, ; 64: System => 0x41761b2c => 50
	i32 1127624469, ; 65: Microsoft.Extensions.Logging.Debug => 0x43362f15 => 37
	i32 1175144683, ; 66: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 109
	i32 1178241025, ; 67: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 99
	i32 1186231468, ; 68: Newtonsoft.Json.Bson.dll => 0x46b474ac => 45
	i32 1204270330, ; 69: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 67
	i32 1220193633, ; 70: Microsoft.Net.Http.Headers => 0x48baad61 => 41
	i32 1267360935, ; 71: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 110
	i32 1292217442, ; 72: Imi.Project.Mobile => 0x4d05ac62 => 27
	i32 1293217323, ; 73: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 81
	i32 1324164729, ; 74: System.Linq => 0x4eed2679 => 135
	i32 1327812513, ; 75: Howest.Prog.Xamarin.UriSourceExtensions.dll => 0x4f24cfa1 => 26
	i32 1364015309, ; 76: System.IO => 0x514d38cd => 132
	i32 1365406463, ; 77: System.ServiceModel.Internals.dll => 0x516272ff => 131
	i32 1376866003, ; 78: Xamarin.AndroidX.SavedState => 0x52114ed3 => 104
	i32 1395857551, ; 79: Xamarin.AndroidX.Media.dll => 0x5333188f => 96
	i32 1406073936, ; 80: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 76
	i32 1408764838, ; 81: System.Runtime.Serialization.Formatters.dll => 0x53f80ba6 => 11
	i32 1411638395, ; 82: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 56
	i32 1418299235, ; 83: FreshIOC => 0x54898763 => 24
	i32 1457743152, ; 84: System.Runtime.Extensions.dll => 0x56e36530 => 134
	i32 1460219004, ; 85: Xamarin.Forms.Xaml => 0x57092c7c => 119
	i32 1462112819, ; 86: System.IO.Compression.dll => 0x57261233 => 126
	i32 1469204771, ; 87: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 65
	i32 1470490898, ; 88: Microsoft.Extensions.Primitives => 0x57a5e912 => 40
	i32 1505131794, ; 89: Microsoft.Extensions.Http => 0x59b67d12 => 35
	i32 1518685258, ; 90: Imi.Project.Mobile.Android.dll => 0x5a854c4a => 0
	i32 1543031311, ; 91: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 133
	i32 1548254347, ; 92: Imi.Project.Mobile.dll => 0x5c487c8b => 27
	i32 1550322496, ; 93: System.Reflection.Extensions.dll => 0x5c680b40 => 16
	i32 1582372066, ; 94: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 80
	i32 1592978981, ; 95: System.Runtime.Serialization.dll => 0x5ef2ee25 => 21
	i32 1600077045, ; 96: FreshMvvm.dll => 0x5f5f3cf5 => 25
	i32 1622152042, ; 97: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 94
	i32 1622358360, ; 98: System.Dynamic.Runtime => 0x60b33958 => 10
	i32 1624863272, ; 99: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 113
	i32 1636350590, ; 100: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 78
	i32 1639515021, ; 101: System.Net.Http.dll => 0x61b9038d => 20
	i32 1639986890, ; 102: System.Text.RegularExpressions => 0x61c036ca => 133
	i32 1657153582, ; 103: System.Runtime => 0x62c6282e => 57
	i32 1658241508, ; 104: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 107
	i32 1658251792, ; 105: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 120
	i32 1670060433, ; 106: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 75
	i32 1701541528, ; 107: System.Diagnostics.Debug.dll => 0x656b7698 => 9
	i32 1726116996, ; 108: System.Reflection.dll => 0x66e27484 => 137
	i32 1729485958, ; 109: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 71
	i32 1765942094, ; 110: System.Reflection.Extensions => 0x6942234e => 16
	i32 1766324549, ; 111: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 106
	i32 1770582343, ; 112: Microsoft.Extensions.Logging.dll => 0x6988f147 => 38
	i32 1776026572, ; 113: System.Core.dll => 0x69dc03cc => 48
	i32 1788241197, ; 114: Xamarin.AndroidX.Fragment => 0x6a96652d => 83
	i32 1796167890, ; 115: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 29
	i32 1808609942, ; 116: Xamarin.AndroidX.Loader => 0x6bcd3296 => 94
	i32 1813201214, ; 117: Xamarin.Google.Android.Material => 0x6c13413e => 120
	i32 1818569960, ; 118: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 100
	i32 1824175904, ; 119: System.Text.Encoding.Extensions => 0x6cbab720 => 18
	i32 1824722060, ; 120: System.Runtime.Serialization.Formatters => 0x6cc30c8c => 11
	i32 1828688058, ; 121: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 36
	i32 1858542181, ; 122: System.Linq.Expressions => 0x6ec71a65 => 139
	i32 1867746548, ; 123: Xamarin.Essentials.dll => 0x6f538cf4 => 115
	i32 1870277092, ; 124: System.Reflection.Primitives => 0x6f7a29e4 => 17
	i32 1878053835, ; 125: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 119
	i32 1885316902, ; 126: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 68
	i32 1904755420, ; 127: System.Runtime.InteropServices.WindowsRuntime.dll => 0x718842dc => 19
	i32 1919157823, ; 128: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 97
	i32 1942524222, ; 129: Imi.Project.Mobile.Android => 0x73c8913e => 0
	i32 1968388702, ; 130: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 32
	i32 1987243864, ; 131: FluentValidation => 0x7672ef58 => 22
	i32 2011961780, ; 132: System.Buffers.dll => 0x77ec19b4 => 47
	i32 2019465201, ; 133: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 92
	i32 2055257422, ; 134: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 89
	i32 2069514766, ; 135: Newtonsoft.Json.Bson => 0x7b5a4a0e => 45
	i32 2079903147, ; 136: System.Runtime.dll => 0x7bf8cdab => 57
	i32 2090596640, ; 137: System.Numerics.Vectors => 0x7c9bf920 => 54
	i32 2097448633, ; 138: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 85
	i32 2126786730, ; 139: Xamarin.Forms.Platform.Android => 0x7ec430aa => 117
	i32 2181898931, ; 140: Microsoft.Extensions.Options.dll => 0x820d22b3 => 39
	i32 2192057212, ; 141: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 36
	i32 2193016926, ; 142: System.ObjectModel.dll => 0x82b6c85e => 12
	i32 2201231467, ; 143: System.Net.Http => 0x8334206b => 20
	i32 2217644978, ; 144: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 109
	i32 2244775296, ; 145: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 95
	i32 2256548716, ; 146: Xamarin.AndroidX.MultiDex => 0x8680336c => 97
	i32 2261435625, ; 147: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 87
	i32 2266799131, ; 148: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 31
	i32 2279755925, ; 149: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 103
	i32 2315684594, ; 150: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 63
	i32 2368005991, ; 151: System.Xml.ReaderWriter.dll => 0x8d24e767 => 13
	i32 2371007202, ; 152: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 32
	i32 2392818924, ; 153: System.Net.Http.Formatting.dll => 0x8e9f84ec => 52
	i32 2409053734, ; 154: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 101
	i32 2435904999, ; 155: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 130
	i32 2454642406, ; 156: System.Text.Encoding.dll => 0x924edee6 => 14
	i32 2465532216, ; 157: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 74
	i32 2471841756, ; 158: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 159: Java.Interop.dll => 0x93918882 => 28
	i32 2501346920, ; 160: System.Data.DataSetExtensions => 0x95178668 => 124
	i32 2505896520, ; 161: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 91
	i32 2562349572, ; 162: Microsoft.CSharp => 0x98ba5a04 => 30
	i32 2570120770, ; 163: System.Text.Encodings.Web => 0x9930ee42 => 58
	i32 2581819634, ; 164: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 110
	i32 2585220780, ; 165: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 18
	i32 2616218305, ; 166: Microsoft.Extensions.Logging.Debug.dll => 0x9bf052c1 => 37
	i32 2620871830, ; 167: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 78
	i32 2624644809, ; 168: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 82
	i32 2633051222, ; 169: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 90
	i32 2664396074, ; 170: System.Xml.XDocument.dll => 0x9ecf752a => 5
	i32 2693849962, ; 171: System.IO.dll => 0xa090e36a => 132
	i32 2701096212, ; 172: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 107
	i32 2715334215, ; 173: System.Threading.Tasks.dll => 0xa1d8b647 => 8
	i32 2724373263, ; 174: System.Runtime.Numerics.dll => 0xa262a30f => 3
	i32 2732626843, ; 175: Xamarin.AndroidX.Activity => 0xa2e0939b => 62
	i32 2737747696, ; 176: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 65
	i32 2760020586, ; 177: Howest.Prog.Xamarin.UriSourceExtensions => 0xa482926a => 26
	i32 2766581644, ; 178: Xamarin.Forms.Core => 0xa4e6af8c => 116
	i32 2778768386, ; 179: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 112
	i32 2810250172, ; 180: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 76
	i32 2819470561, ; 181: System.Xml.dll => 0xa80db4e1 => 60
	i32 2824502124, ; 182: System.Xml.XmlDocument => 0xa85a7b6c => 4
	i32 2853208004, ; 183: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 112
	i32 2855708567, ; 184: Xamarin.AndroidX.Transition => 0xaa36a797 => 108
	i32 2900621748, ; 185: System.Dynamic.Runtime.dll => 0xace3f9b4 => 10
	i32 2901442782, ; 186: System.Reflection => 0xacf080de => 137
	i32 2903344695, ; 187: System.ComponentModel.Composition => 0xad0d8637 => 128
	i32 2905242038, ; 188: mscorlib.dll => 0xad2a79b6 => 43
	i32 2916838712, ; 189: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 113
	i32 2919462931, ; 190: System.Numerics.Vectors.dll => 0xae037813 => 54
	i32 2921128767, ; 191: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 64
	i32 2978675010, ; 192: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 81
	i32 3024354802, ; 193: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 86
	i32 3044182254, ; 194: FormsViewGroup => 0xb57288ee => 23
	i32 3057625584, ; 195: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 98
	i32 3075834255, ; 196: System.Threading.Tasks => 0xb755818f => 8
	i32 3111772706, ; 197: System.Runtime.Serialization => 0xb979e222 => 21
	i32 3124832203, ; 198: System.Threading.Tasks.Extensions => 0xba4127cb => 141
	i32 3159123045, ; 199: System.Reflection.Primitives.dll => 0xbc4c6465 => 17
	i32 3204380047, ; 200: System.Data.dll => 0xbefef58f => 122
	i32 3209718065, ; 201: System.Xml.XmlDocument.dll => 0xbf506931 => 4
	i32 3211777861, ; 202: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 80
	i32 3220365878, ; 203: System.Threading => 0xbff2e236 => 15
	i32 3247949154, ; 204: Mono.Security => 0xc197c562 => 140
	i32 3257332390, ; 205: MvvmHelpers => 0xc226f2a6 => 44
	i32 3258312781, ; 206: Xamarin.AndroidX.CardView => 0xc235e84d => 71
	i32 3265893370, ; 207: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 141
	i32 3267021929, ; 208: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 69
	i32 3280506390, ; 209: System.ComponentModel.Annotations.dll => 0xc3888e16 => 2
	i32 3299363146, ; 210: System.Text.Encoding => 0xc4a8494a => 14
	i32 3317135071, ; 211: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 79
	i32 3317144872, ; 212: System.Data => 0xc5b79d28 => 122
	i32 3340431453, ; 213: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 68
	i32 3346324047, ; 214: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 99
	i32 3353484488, ; 215: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 85
	i32 3353544232, ; 216: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 114
	i32 3358260929, ; 217: System.Text.Json => 0xc82afec1 => 59
	i32 3361254415, ; 218: FreshIOC.dll => 0xc858ac0f => 24
	i32 3362522851, ; 219: Xamarin.AndroidX.Core => 0xc86c06e3 => 77
	i32 3366347497, ; 220: Java.Interop => 0xc8a662e9 => 28
	i32 3374999561, ; 221: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 103
	i32 3395150330, ; 222: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 56
	i32 3404865022, ; 223: System.ServiceModel.Internals => 0xcaf21dfe => 131
	i32 3407215217, ; 224: Xamarin.CommunityToolkit => 0xcb15fa71 => 114
	i32 3428513518, ; 225: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 34
	i32 3429136800, ; 226: System.Xml => 0xcc6479a0 => 60
	i32 3430777524, ; 227: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 228: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 82
	i32 3471940407, ; 229: System.ComponentModel.TypeConverter.dll => 0xcef19b37 => 138
	i32 3476120550, ; 230: Mono.Android => 0xcf3163e6 => 42
	i32 3485117614, ; 231: System.Text.Json.dll => 0xcfbaacae => 59
	i32 3486566296, ; 232: System.Transactions => 0xcfd0c798 => 123
	i32 3493954962, ; 233: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 73
	i32 3501239056, ; 234: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 69
	i32 3509114376, ; 235: System.Xml.Linq => 0xd128d608 => 61
	i32 3536029504, ; 236: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 117
	i32 3567349600, ; 237: System.ComponentModel.Composition.dll => 0xd4a16f60 => 128
	i32 3608519521, ; 238: System.Linq.dll => 0xd715a361 => 135
	i32 3618140916, ; 239: Xamarin.AndroidX.Preference => 0xd7a872f4 => 101
	i32 3623953038, ; 240: FluentValidation.dll => 0xd801228e => 22
	i32 3627220390, ; 241: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 102
	i32 3632359727, ; 242: Xamarin.Forms.Platform => 0xd881692f => 118
	i32 3633644679, ; 243: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 64
	i32 3641597786, ; 244: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 89
	i32 3645089577, ; 245: System.ComponentModel.DataAnnotations => 0xd943a729 => 130
	i32 3657292374, ; 246: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 31
	i32 3672681054, ; 247: Mono.Android.dll => 0xdae8aa5e => 42
	i32 3676310014, ; 248: System.Web.Services.dll => 0xdb2009fe => 129
	i32 3682565725, ; 249: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 70
	i32 3684561358, ; 250: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 73
	i32 3684933406, ; 251: System.Runtime.InteropServices.WindowsRuntime => 0xdba39f1e => 19
	i32 3689375977, ; 252: System.Drawing.Common => 0xdbe768e9 => 125
	i32 3718780102, ; 253: Xamarin.AndroidX.Annotation => 0xdda814c6 => 63
	i32 3724971120, ; 254: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 98
	i32 3731644420, ; 255: System.Reactive => 0xde6c6004 => 55
	i32 3748608112, ; 256: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 49
	i32 3758932259, ; 257: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 87
	i32 3786282454, ; 258: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 72
	i32 3822602673, ; 259: Xamarin.AndroidX.Media => 0xe3d849b1 => 96
	i32 3829621856, ; 260: System.Numerics.dll => 0xe4436460 => 53
	i32 3841636137, ; 261: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 33
	i32 3885922214, ; 262: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 108
	i32 3896760992, ; 263: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 77
	i32 3920810846, ; 264: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 127
	i32 3921031405, ; 265: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 111
	i32 3928044579, ; 266: System.Xml.ReaderWriter => 0xea213423 => 13
	i32 3931092270, ; 267: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 100
	i32 3945713374, ; 268: System.Data.DataSetExtensions.dll => 0xeb2ecede => 124
	i32 3955647286, ; 269: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 66
	i32 4025784931, ; 270: System.Memory => 0xeff49a63 => 51
	i32 4044155772, ; 271: Microsoft.Net.Http.Headers.dll => 0xf10ceb7c => 41
	i32 4073602200, ; 272: System.Threading.dll => 0xf2ce3c98 => 15
	i32 4105002889, ; 273: Mono.Security.dll => 0xf4ad5f89 => 140
	i32 4126470640, ; 274: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 34
	i32 4131741489, ; 275: System.Net.Http.Formatting => 0xf6455f31 => 52
	i32 4151237749, ; 276: System.Core => 0xf76edc75 => 48
	i32 4151317942, ; 277: FreshMvvm => 0xf77015b6 => 25
	i32 4181436372, ; 278: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 136
	i32 4182413190, ; 279: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 93
	i32 4213026141, ; 280: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 49
	i32 4260525087, ; 281: System.Buffers => 0xfdf2741f => 47
	i32 4274976490, ; 282: System.Runtime.Numerics => 0xfecef6ea => 3
	i32 4292120959 ; 283: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 93
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [284 x i32] [
	i32 91, i32 121, i32 46, i32 116, i32 105, i32 105, i32 2, i32 72, ; 0..7
	i32 106, i32 70, i32 9, i32 86, i32 30, i32 7, i32 129, i32 75, ; 8..15
	i32 90, i32 84, i32 35, i32 62, i32 53, i32 88, i32 51, i32 74, ; 16..23
	i32 115, i32 6, i32 83, i32 136, i32 43, i32 50, i32 84, i32 95, ; 24..31
	i32 12, i32 40, i32 123, i32 38, i32 134, i32 29, i32 127, i32 55, ; 32..39
	i32 79, i32 58, i32 111, i32 67, i32 61, i32 126, i32 39, i32 125, ; 40..47
	i32 44, i32 102, i32 7, i32 121, i32 46, i32 88, i32 23, i32 5, ; 48..55
	i32 6, i32 104, i32 33, i32 66, i32 118, i32 139, i32 92, i32 138, ; 56..63
	i32 50, i32 37, i32 109, i32 99, i32 45, i32 67, i32 41, i32 110, ; 64..71
	i32 27, i32 81, i32 135, i32 26, i32 132, i32 131, i32 104, i32 96, ; 72..79
	i32 76, i32 11, i32 56, i32 24, i32 134, i32 119, i32 126, i32 65, ; 80..87
	i32 40, i32 35, i32 0, i32 133, i32 27, i32 16, i32 80, i32 21, ; 88..95
	i32 25, i32 94, i32 10, i32 113, i32 78, i32 20, i32 133, i32 57, ; 96..103
	i32 107, i32 120, i32 75, i32 9, i32 137, i32 71, i32 16, i32 106, ; 104..111
	i32 38, i32 48, i32 83, i32 29, i32 94, i32 120, i32 100, i32 18, ; 112..119
	i32 11, i32 36, i32 139, i32 115, i32 17, i32 119, i32 68, i32 19, ; 120..127
	i32 97, i32 0, i32 32, i32 22, i32 47, i32 92, i32 89, i32 45, ; 128..135
	i32 57, i32 54, i32 85, i32 117, i32 39, i32 36, i32 12, i32 20, ; 136..143
	i32 109, i32 95, i32 97, i32 87, i32 31, i32 103, i32 63, i32 13, ; 144..151
	i32 32, i32 52, i32 101, i32 130, i32 14, i32 74, i32 1, i32 28, ; 152..159
	i32 124, i32 91, i32 30, i32 58, i32 110, i32 18, i32 37, i32 78, ; 160..167
	i32 82, i32 90, i32 5, i32 132, i32 107, i32 8, i32 3, i32 62, ; 168..175
	i32 65, i32 26, i32 116, i32 112, i32 76, i32 60, i32 4, i32 112, ; 176..183
	i32 108, i32 10, i32 137, i32 128, i32 43, i32 113, i32 54, i32 64, ; 184..191
	i32 81, i32 86, i32 23, i32 98, i32 8, i32 21, i32 141, i32 17, ; 192..199
	i32 122, i32 4, i32 80, i32 15, i32 140, i32 44, i32 71, i32 141, ; 200..207
	i32 69, i32 2, i32 14, i32 79, i32 122, i32 68, i32 99, i32 85, ; 208..215
	i32 114, i32 59, i32 24, i32 77, i32 28, i32 103, i32 56, i32 131, ; 216..223
	i32 114, i32 34, i32 60, i32 1, i32 82, i32 138, i32 42, i32 59, ; 224..231
	i32 123, i32 73, i32 69, i32 61, i32 117, i32 128, i32 135, i32 101, ; 232..239
	i32 22, i32 102, i32 118, i32 64, i32 89, i32 130, i32 31, i32 42, ; 240..247
	i32 129, i32 70, i32 73, i32 19, i32 125, i32 63, i32 98, i32 55, ; 248..255
	i32 49, i32 87, i32 72, i32 96, i32 53, i32 33, i32 108, i32 77, ; 256..263
	i32 127, i32 111, i32 13, i32 100, i32 124, i32 66, i32 51, i32 41, ; 264..271
	i32 15, i32 140, i32 34, i32 52, i32 48, i32 25, i32 136, i32 93, ; 272..279
	i32 49, i32 47, i32 3, i32 93 ; 280..283
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
