using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset textJSON;
    
    
    [System.Serializable]
    public class TxWrapper
    {
        public Tx tx;
    }

    [System.Serializable]
    public class Tx
    {
        public int type;
        public int size;
        public int loop;
        public int seqCount;
        public List<Seq4> seq;
    }

    [System.Serializable]
    public class TxList
    {
        public List<Tx> tx;
    }
    public TxWrapper myTxList = new TxWrapper();

    [System.Serializable]
    public class AxWrapper
    {
        public Ax ax;
    }

    [System.Serializable]
    public class Ax
    {
        public int type;
        public int size;
        public int loop;
        public int seqCount;
        public List<Seq3> seq;
    }

    [System.Serializable]
    public class AxList
    {
        public List<Ax> ax;
    }
    public AxWrapper myAxList = new AxWrapper();

    [System.Serializable]
    public class DxWrapper
    {
        public Dx dx;
    }

    [System.Serializable]
    public class Dx
    {
        public int type;
        public int size;
        public int loop;
        public int seqCount;
        public List<Seq> seq;
    }

    [System.Serializable]
    public class DxList
    {
        public List<Dx> dx;
    }
    public DxWrapper myDxList = new DxWrapper();

    [System.Serializable]
    public class MxWrapper
    {
        public Mx mx;
    }

    [System.Serializable]
    public class Mx
    {
        public int type;
        public int size;
        public int motion_type;
        public int loop;
        public int kp;
        public int ki;
        public int kd;
        public int pidcontrol;
        public int seqCount;
        public List<Seq1> seq;
    }

    [System.Serializable]
    public class MxList
    {
        public List<Mx> mx;
    }
    public MxWrapper myMxList = new MxWrapper();


    [System.Serializable]
    public class Ix1Wrapper
    {
        public Ix1 ix1;
    }

    [System.Serializable]
    public class Ix1
    {
        public int type;
        public int size;
        public int imagetype;
        public int loop;
        public int seqCount; 
        public List<Seq2> seq;
        
    }

    [System.Serializable]
    public class Ix1List
    {
        public List<Ix1> ix1;
    }
    public Ix1Wrapper myIx1List = new Ix1Wrapper();
    

    [System.Serializable]
    public class RxWrapper
    {
        public Rx rx;
    }

    [System.Serializable]
    public class Rx
    {
        public int type;
        public int size;
        public int loop;
        public int seqCount;
        public List<Seq> seq;
    }

    [System.Serializable]
    public class RxList
    {
        public List<Rx> rx;
    }
    public RxWrapper myRxList = new RxWrapper();

    [System.Serializable]
    public class Seq
    {
        public string data;
        public string data_dsp;
        public int length;
        public int id;
        public int time;
        public int linear;
        public int angular;
        public int type;
        public string frame;
        public int rate;
        public int loop;
        public int start_frame;
        public int end_frame;
    }

    [System.Serializable]
    public class Seq1
    {
        public int linear;
        public int angular;
        public int time;
        public int type;
        public int id;        
    }

    [System.Serializable]
    public class Seq2
    {
        public string frame;
        public int rate;
        public int id;
        public int loop;
        public int start_frame;
        public int end_frame;
    }

    [System.Serializable]
    public class Seq3
    {
        public string data;
        public int length;
        public int id;
        public int time;
    }

    [System.Serializable]
    public class Seq4
    {
        public string data;
        public string data_dsp;
        public int length;
        public int id;
        public int time;
    }

    /*

    [System.Serializable]
    public class RootWrapper
    {
        public Root root;
    }
    
    
    [System.Serializable]
    public class Root
    {
        public TxWrapper myTxList = new TxWrapper();
        public Ax ax;
        public DxWrapper myDxList = new DxWrapper();
        public Mx mx;
        public Ix1 ix1;
        public Rx rx;
        public int id;
    }

    [System.Serializable]
    public class RootList
    {
        public Root[] root;
        public TxWrapper myTxList = new TxWrapper();
    }
    public RootWrapper myRootList = new RootWrapper();
    */

    void Start()
    {
        //myRootList = JsonUtility.FromJson<RootWrapper>(textJSON.text);
        //Application.persistentDataPath;
        Debug.Log(Application.persistentDataPath);
        myTxList = JsonUtility.FromJson<TxWrapper>(textJSON.text);
        myAxList = JsonUtility.FromJson<AxWrapper>(textJSON.text);
        myDxList = JsonUtility.FromJson<DxWrapper>(textJSON.text);
        myMxList = JsonUtility.FromJson<MxWrapper>(textJSON.text);
        myIx1List = JsonUtility.FromJson<Ix1Wrapper>(textJSON.text);
        myRxList = JsonUtility.FromJson<RxWrapper>(textJSON.text);
        
    }
}
