using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // 音源の取得
    [SerializeField] public AudioClip[] sound = new AudioClip[28];

    // AudioSourceの取得
    AudioSource audioSource;

    // Audioのボリュームを変更するための変数
    public float soundVolume;

    // Audioのボリュームを１で固定するための変数
    public int maxVolume = 1;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSourceのコンポーネントを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // アルファベット'A'〜'Z'と'ー'と'Space'キーのSE
        if (Input.GetKeyDown(KeyCode.A)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[0]); }
        if (Input.GetKeyUp(KeyCode.A)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.B)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[1]); }
        if (Input.GetKeyUp(KeyCode.B)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.C)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[2]); }
        if (Input.GetKeyUp(KeyCode.C)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.D)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[3]); }
        if (Input.GetKeyUp(KeyCode.D)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.E)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[4]); }
        if (Input.GetKeyUp(KeyCode.E)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.F)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[5]); }
        if (Input.GetKeyUp(KeyCode.F)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.G)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[6]); }
        if (Input.GetKeyUp(KeyCode.G)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.H)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[7]); }
        if (Input.GetKeyUp(KeyCode.H)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.I)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[8]); }
        if (Input.GetKeyUp(KeyCode.I)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.J)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[9]); }
        if (Input.GetKeyUp(KeyCode.J)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.K)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[10]); }
        if (Input.GetKeyUp(KeyCode.K)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.L)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[11]); }
        if (Input.GetKeyUp(KeyCode.L)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.M)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[12]); }
        if (Input.GetKeyUp(KeyCode.M)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.N)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[13]); }
        if (Input.GetKeyUp(KeyCode.N)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.O)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[14]); }
        if (Input.GetKeyUp(KeyCode.O)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.P)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[15]); }
        if (Input.GetKeyUp(KeyCode.P)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.Q)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[16]); }
        if (Input.GetKeyUp(KeyCode.Q)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.R)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[17]); }
        if (Input.GetKeyUp(KeyCode.R)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.S)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[18]); }
        if (Input.GetKeyUp(KeyCode.S)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.T)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[19]); }
        if (Input.GetKeyUp(KeyCode.T)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.U)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[20]); }
        if (Input.GetKeyUp(KeyCode.U)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.V)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[21]); }
        if (Input.GetKeyUp(KeyCode.V)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.W)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[22]); }
        if (Input.GetKeyUp(KeyCode.W)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.X)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[23]); }
        if (Input.GetKeyUp(KeyCode.X)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.Y)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[24]); }
        if (Input.GetKeyUp(KeyCode.Y)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.Z)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[25]); }
        if (Input.GetKeyUp(KeyCode.Z)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.Minus)) { audioSource.volume = soundVolume; audioSource.PlayOneShot(sound[26]); }
        if (Input.GetKeyUp(KeyCode.Minus)) { audioSource.Stop(); }
        if (Input.GetKeyDown(KeyCode.Space)) { audioSource.volume = maxVolume; audioSource.PlayOneShot(sound[27]); }
    }

    // ボタンが押されたときに決定音を鳴らす関数
    public void On_ClickButtonSE()
    {
        // audioのボリュームは１に固定
        audioSource.volume = maxVolume;

        // 決定音を鳴らす
        audioSource.PlayOneShot(sound[27]);
    }
}
