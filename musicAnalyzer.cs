using UnityEngine;
using System.Collections;

public class musicAnalyzer : MonoBehaviour {

	public GameObject[] _bars;

	public float juice = 8;
	public float rate = 10;
	public float mytime = 1;
	public float speed = .1f;
	
	private float[] spec;
	
	private float specMag01;
	private float specMag02;
	private float specMag03;
	private float specMag04;
	private float specMag05;
	private float specMag06;
	private float specMag07;
	private float specMag08;
	private float specMag09;
	private float specMag10;
	private float specMag11;
	private float specMag12;
	private float specMag13;
	private float specMag14;
	private float specMag15;
	private float specMag16;
	private float specMag17;
	private float specMag18;
	private float specMag19;
	private float specMag20;
	private float specMag21;
	private float specMag22;
	private float specMag23;
	private float specMag24;
	private float specMag25;
	private float specMag26;
	private float specMag27;
	private float specMag28;
	private float specMag29;
	private float specMag30;
	private float specMag31;
	private float specMag32;
	private float specMag33;
	private float specMag34;
	private float specMag35;
	private float specMag36;
	private float specMag37;
	private float specMag38;
	private float specMag39;
	private float specMag40;
	private float specMag41;
	private float specMag42;
	private float specMag43;
	private float specMag44;
	private float specMag45;
	private float specMag46;
	private float specMag47;
	private float specMag48;
	private float specMag49;
	private float specMag50;
	private float specMag51;
	private float specMag52;
	private float specMag53;
	private float specMag54;
	private float specMag55;
	private float specMag56;
	private float specMag57;
	private float specMag58;
	private float specMag59;
	private float specMag60;
	private float specMag61;
	private float specMag62;
	private float specMag63;
	private float specMag64;
	

	public Material particleMaterial;
	public float timeModulo;
	public float _cpt = 0.0f;
	public int colorPrecision;
	public Color _randomColor;

	void Start(){
		_randomColor = new Color((float)Random.Range(0, colorPrecision) / (float)colorPrecision, (float)Random.Range(0, colorPrecision) / (float)colorPrecision, (float)Random.Range(0, colorPrecision) / (float)colorPrecision, 1.0f);
	}

	void music(){
		GetComponent<AudioSource>().Play ();
	}
	
	void Update () {

		if (Time.time - _cpt > timeModulo)
		{
			_cpt = Time.time;
			_randomColor = new Color((float)Random.Range(0, colorPrecision) / (float)colorPrecision, (float)Random.Range(0, colorPrecision) / (float)colorPrecision, (float)Random.Range(0, colorPrecision) / (float)colorPrecision, 1.0f);			
		}
		particleMaterial.SetColor("_Color", Color.Lerp(particleMaterial.color, _randomColor, Time.smoothDeltaTime));
		particleMaterial.SetColor("_EmissionColor", Color.Lerp(particleMaterial.color, _randomColor, Time.smoothDeltaTime));

		spec = AudioListener.GetSpectrumData(8192,0,FFTWindow.BlackmanHarris);
		//spec = AudioListener.GetOutputData(1024,0);
		
		
		
		//specMag01 = spec[0];// + spec[25] + spec [50];
		//specMag02 = spec[1];// + spec[150] + spec [175];
		//specMag03 = spec[2];// + spec[275] + spec [300];
		//specMag04 = spec[3];// + spec[400] + spec [425];
		//specMag05 = spec[4];// + spec[525] + spec [550];
		specMag06 = spec[5] + spec[675] + spec [700];
		specMag07 = spec[6] + spec[775] + spec [800];
		specMag08 = spec[7] + spec[925] + spec [950];
		specMag09 = spec[8] + spec[1050] + spec [1075];
		specMag10 = spec[9] + spec[1175] + spec [1200];
		specMag11 = spec[10] + spec[25] + spec [50];
		specMag12 = spec[11] + spec[150] + spec [175];
		specMag13 = spec[12] + spec[275] + spec [300];
		specMag14 = spec[13]+ spec[14] + spec[400] + spec [425];
		specMag15 = spec[15] + spec[525] + spec[550];
		specMag16 = spec[16]+ spec[17] + spec[675] + spec[700];
		specMag17 = spec[18] + spec[775] + spec[800];
		specMag18 = spec[19]+ spec[20];// + spec[925] + spec [950];
		specMag19 = spec[21];// + spec[1050] + spec [1075];
		specMag20 = spec[22]+ spec[23];// + spec[1175] + spec [1200];
		specMag21 = spec[24]+ spec[25] + spec[26];// + spec[25] + spec [50];
		specMag22 = spec[27]+ spec[28] + spec[29];// + spec[150] + spec [175];
		specMag23 = spec[30]+ spec[31] + spec[32];// + spec[275] + spec [300];
		specMag24 = spec[33]+ spec[34] + spec[35];// + spec[400] + spec [425];
		specMag25 = spec[36]+ spec[37] + spec[38];// + spec[525] + spec [550];
		specMag26 = spec[39]+ spec[40];
		specMag27 = spec[41]+ spec[42] + spec[43];
		specMag28 = spec[44]+ spec[45] + spec[46];
		specMag29 = spec[48]+ spec[49] + spec[50] + spec[51] + spec[52] + spec[53];
		specMag30 = spec[54]+ spec[55] + spec[56] + spec[57] + spec[58] + spec[59];
		specMag31 = spec[60]+ spec[61] + spec[62] + spec[63] + spec[64];
		specMag32 = spec[65]+ spec[66] + spec[67] + spec[68] + spec[69] + spec[70];
		specMag33 = spec[71]+ spec[72] + spec[73] + spec[74] + spec[75] + spec[76];
		specMag34 = spec[77]+ spec[78] + spec[79] + spec[80] + spec[81] + spec[82];
		specMag35 = spec[83]+ spec[84] + spec[85] + spec[86] + spec[87] + spec[88];
		specMag36 = spec[89]+ spec[90] + spec[91] + spec[92] + spec[93] + spec[94];
		specMag37 = spec[95]+ spec[96] + spec[97] + spec[98] + spec[99] + spec[100] +spec[101] + spec[102] + spec[103] + spec[104];
		specMag38 = spec[105]+ spec[106] + spec[107] + spec[108] + spec[109] + spec[110] + spec[111] + spec[113] + spec[114] + spec[115];
		specMag39 = spec[116]+ spec[117] + spec[118] + spec[119] + spec[120] + spec[121] + spec[122] + spec[123] + spec[124] + spec[125];
		
		specMag40 = spec[126]+ spec[127] + spec[128] + spec[129] + spec[130] + spec[131] + spec[132] + spec[133] + spec[134] + spec[135];
		specMag41 = spec[136]+ spec[137] + spec[138] + spec[139] + spec[140] + spec[141] + spec[142] + spec[143] + spec[144] + spec[145];
		specMag42 = spec[146]+ spec[147] + spec[148] + spec[149] + spec[150] + spec[151] + spec[152] + spec[153] + spec[154] + spec[155];
		specMag43 = spec[156]+ spec[157] + spec[158] + spec[159] + spec[160] + spec[161] + spec[162] + spec[163] + spec[164] + spec[165];
		specMag44 = spec[166]+ spec[167] + spec[168] + spec[169] + spec[170] + spec[171] + spec[172] + spec[173] + spec[174] + spec[175];
		specMag45 = spec[176]+ spec[177] + spec[178] + spec[179] + spec[180] + spec[181] + spec[182] + spec[183] + spec[184] + spec[185];
		specMag46 = spec[186]+ spec[187] + spec[188] + spec[189] + spec[190] + spec[191] + spec[192] + spec[193] + spec[194] + spec[195];
		specMag47 = spec[196]+ spec[197] + spec[198] + spec[199] + spec[200] + spec[201] + spec[202] + spec[203] + spec[204] + spec[205];
		specMag48 = spec[206]+ spec[207] + spec[208] + spec[209] + spec[210] + spec[211] + spec[212] + spec[213] + spec[214] + spec[215];
		specMag49 = spec[216]+ spec[217] + spec[218] + spec[219] + spec[220] + spec[221] + spec[222] + spec[223] + spec[224] + spec[225];
		specMag50 = spec[226]+ spec[227] + spec[228] + spec[229] + spec[230] + spec[231] + spec[232] + spec[233] + spec[234] + spec[235];
		specMag51 = spec[236]+ spec[237] + spec[238] + spec[239] + spec[240] + spec[241] + spec[242] + spec[243] + spec[244] + spec[245];
		specMag52 = spec[246]+ spec[247] + spec[248] + spec[249] + spec[250] + spec[251] + spec[252] + spec[253] + spec[254] + spec[255];
		
		specMag01 = spec[256]+ spec[257] + spec[258] + spec[259] + spec[260] + spec[261] + spec[262] + spec[263] + spec[264] + spec[265];
		specMag02 = spec[266]+ spec[267] + spec[268] + spec[269] + spec[270] + spec[271] + spec[272] + spec[273] + spec[274] + spec[275];
		specMag03 = spec[276]+ spec[278] + spec[279] + spec[280] + spec[281] + spec[282] + spec[283] + spec[284] + spec[285] + spec[286];
		specMag04 = spec[287]+ spec[288] + spec[289] + spec[290] + spec[291] + spec[292] + spec[293] + spec[294] + spec[295] + spec[296];
		specMag05 = spec[297]+ spec[298] + spec[299] + spec[300] + spec[301] + spec[302] + spec[303] + spec[304] + spec[305] + spec[306];
		
		
		

		_bars[0].gameObject.transform.localScale = new Vector3(1,specMag01*juice,1);
		_bars[1].gameObject.transform.localScale = new Vector3(1,specMag02*juice,1);
		_bars[2].gameObject.transform.localScale = new Vector3(1,specMag03*juice,1);
		_bars[3].gameObject.transform.localScale = new Vector3(1,specMag04*juice,1);
		_bars[4].gameObject.transform.localScale = new Vector3(1,specMag05*juice,1);
		_bars[5].gameObject.transform.localScale = new Vector3(1,specMag06*juice,1);
		_bars[6].gameObject.transform.localScale = new Vector3(1,specMag07*juice,1);
		_bars[7].gameObject.transform.localScale = new Vector3(1,specMag08*juice,1);
		_bars[8].gameObject.transform.localScale = new Vector3(1,specMag09*juice,1);
		_bars[9].gameObject.transform.localScale = new Vector3(1,specMag10*juice,1);
		_bars[10].gameObject.transform.localScale = new Vector3(1,specMag11*juice,1);
		_bars[11].gameObject.transform.localScale = new Vector3(1,specMag12*juice,1);
		_bars[12].gameObject.transform.localScale = new Vector3(1,specMag13*juice,1);
		_bars[13].gameObject.transform.localScale = new Vector3(1,specMag14*juice,1);
		_bars[14].gameObject.transform.localScale = new Vector3(1,specMag15*juice,1);
		_bars[15].gameObject.transform.localScale = new Vector3(1,specMag16*juice,1);
		_bars[16].gameObject.transform.localScale = new Vector3(1,specMag17*juice,1);
		_bars[17].gameObject.transform.localScale = new Vector3(1,specMag18*juice,1);
		_bars[18].gameObject.transform.localScale = new Vector3(1,specMag19*juice,1);
		_bars[19].gameObject.transform.localScale = new Vector3(1,specMag20*juice,1);
		_bars[20].gameObject.transform.localScale = new Vector3(1,specMag21*juice,1);
		_bars[21].gameObject.transform.localScale = new Vector3(1,specMag22*juice,1);
		_bars[22].gameObject.transform.localScale = new Vector3(1,specMag23*juice,1);
		_bars[23].gameObject.transform.localScale = new Vector3(1,specMag24*juice,1);
		_bars[24].gameObject.transform.localScale = new Vector3(1,specMag25*juice,1);
		_bars[25].gameObject.transform.localScale = new Vector3(1,specMag26*juice,1);
		_bars[26].gameObject.transform.localScale = new Vector3(1,specMag27*juice,1);
		_bars[27].gameObject.transform.localScale = new Vector3(1,specMag28*juice,1);
		_bars[28].gameObject.transform.localScale = new Vector3(1,specMag29*juice,1);
		_bars[29].gameObject.transform.localScale = new Vector3(1,specMag30*juice,1);
		_bars[30].gameObject.transform.localScale = new Vector3(1,specMag31*juice,1);
		_bars[31].gameObject.transform.localScale = new Vector3(1,specMag32*juice,1);
		_bars[32].gameObject.transform.localScale = new Vector3(1,specMag33*juice,1);
		_bars[33].gameObject.transform.localScale = new Vector3(1,specMag34*juice,1);
		_bars[34].gameObject.transform.localScale = new Vector3(1,specMag35*juice,1);
		_bars[35].gameObject.transform.localScale = new Vector3(1,specMag36*juice,1);
		_bars[36].gameObject.transform.localScale = new Vector3(1,specMag37*juice,1);
		_bars[37].gameObject.transform.localScale = new Vector3(1,specMag38*juice,1);
		_bars[38].gameObject.transform.localScale = new Vector3(1,specMag39*juice,1);
		_bars[39].gameObject.transform.localScale = new Vector3(1,specMag40*juice,1);
		_bars[40].gameObject.transform.localScale = new Vector3(1,specMag41*juice,1);
		_bars[41].gameObject.transform.localScale = new Vector3(1,specMag42*juice,1);
		_bars[42].gameObject.transform.localScale = new Vector3(1,specMag43*juice,1);
		_bars[43].gameObject.transform.localScale = new Vector3(1,specMag44*juice,1);
		_bars[44].gameObject.transform.localScale = new Vector3(1,specMag45*juice,1);
		_bars[45].gameObject.transform.localScale = new Vector3(1,specMag46*juice,1);
		_bars[46].gameObject.transform.localScale = new Vector3(1,specMag47*juice,1);
		_bars[47].gameObject.transform.localScale = new Vector3(1,specMag48*juice,1);
		_bars[48].gameObject.transform.localScale = new Vector3(1,specMag49*juice,1);
		_bars[49].gameObject.transform.localScale = new Vector3(1,specMag50*juice,1);
		_bars[50].gameObject.transform.localScale = new Vector3(1,specMag51*juice,1);
		_bars[51].gameObject.transform.localScale = new Vector3(1,specMag52*juice,1);

		
	}	

}
