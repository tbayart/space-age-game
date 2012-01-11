﻿// The Codes contain in this class is the original code adopted from XCrypt.
// Special thanks to XCrypt Project.
// XCrypt Project Site: http://www.codeproject.com/KB/security/xcrypt.aspx
//
// This class contains encryption library for the below encryption method:
// SHA, SHA256, SHA384, SHA512, MD5
// DES, RC2, Rijndael, TripleDES, BlowFish, Twofish
//
// License: This article, along with any associated source code and files, 
//          is licensed under The Apache License, Version 2.0
// 
// Author : pdwolf
// Origin : Singapore
// Last Update: 19 Aug 2003


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security;
using Blowfish_NET;
using Twofish_NET;

namespace XCrypt
{
    // for non-.NetFramework compatiable encryption methods
    //public class extEncryption 
    //{

    //}

    public class XCryptEngine
    {
        public enum AlgorithmType : int
        {
            None, SHA, SHA256, SHA384, SHA512, MD5,
            DES, RC2, Rijndael, TripleDES, BlowFish, Twofish
        }

        private AlgorithmType _algorithm = AlgorithmType.None;

        public AlgorithmType Algorithm
        {
            get { return _algorithm; }
            set
            {
                _algorithm = value;
                InitializeEngine();
            }
        }

        private bool _isHash;
        public bool IsHashAlgorithm
        {
            get { return _isHash; }
            set { }
        }
        private bool _isSymmetric;
        public bool IsSymmetricAlgorithm
        {
            get { return _isSymmetric; }
            set { }
        }

        private string _key = null;
        public string Key
        {
            get { return _key; }
            set { _key = this.formatKey(value); }
        }
        private string DefaultKey = "";

        private HashAlgorithmEngine _he;
        private SymmetricAlgorithmEngine _se;

        private string formatKey(string k)
        {
            if (k == null || k.Length == 0) return null;
            return k.Trim();
        }

        public XCryptEngine()
        {
            //InitializeEngine();
            DefaultKey = "abcdefg";
        }

        public XCryptEngine(AlgorithmType al)
        {
            _algorithm = al;
            DefaultKey = "abcdefg";

            InitializeEngine();
        }

        public string Decrypt(string src)
        {
            string result = "";

            if (_isSymmetric)
            {
                if (_key == null)
                    result = _se.Decrypting(src, DefaultKey);
                else result = _se.Decrypting(src, _key);
            }

            return result;
        }

        public string Decrypt(string src, string ckey)
        {
            string result = "";

            if (_isSymmetric)
            {
                result = _se.Decrypting(src, ckey);
            }

            return result;
        }

        public string Encrypt(string src)
        {
            string result = "";

            if (_isHash)
            {
                result = _he.Encoding(src);
            }
            else if (_isSymmetric)
            {
                if (_key == null)
                    result = _se.Encrypting(src, DefaultKey);
                else result = _se.Encrypting(src, _key);
            }

            return result;
        }

        public string Encrypt(string src, string ckey)
        {
            string result = "";

            if (_isHash)
            {
                result = _he.Encoding(src);
            }
            else if (_isSymmetric)
            {
                result = _se.Encrypting(src, ckey);
            }

            return result;
        }

        public bool DestroyEngine()
        {
            _se = null;
            _he = null;
            return true;
        }

        public bool InitializeEngine(AlgorithmType at)
        {
            _algorithm = at;

            return InitializeEngine();
        }

        public bool InitializeEngine()
        {
            if (_algorithm == AlgorithmType.None)
                return false;

            if (_algorithm == AlgorithmType.BlowFish ||
                _algorithm == AlgorithmType.DES ||
                _algorithm == AlgorithmType.RC2 ||
                _algorithm == AlgorithmType.Rijndael ||
                _algorithm == AlgorithmType.TripleDES ||
                _algorithm == AlgorithmType.Twofish)
            {
                _isSymmetric = true;
                _isHash = false;
            }
            else
                if (_algorithm == AlgorithmType.MD5 ||
                    _algorithm == AlgorithmType.SHA ||
                    _algorithm == AlgorithmType.SHA256 ||
                    _algorithm == AlgorithmType.SHA384 ||
                    _algorithm == AlgorithmType.SHA512)
                {
                    _isSymmetric = false;
                    _isHash = true;
                }

            _se = null;
            _he = null;
            switch (_algorithm)
            {
                case AlgorithmType.BlowFish:
                    _se = new SymmetricAlgorithmEngine(SymmetricAlgorithmEngine.EncodeMethodEnum.BlowFish);
                    break;
                case AlgorithmType.DES:
                    _se = new SymmetricAlgorithmEngine(SymmetricAlgorithmEngine.EncodeMethodEnum.DES);
                    break;
                case AlgorithmType.MD5:
                    _he = new HashAlgorithmEngine(HashAlgorithmEngine.EncodeMethodEnum.MD5);
                    break;
                case AlgorithmType.RC2:
                    _se = new SymmetricAlgorithmEngine(SymmetricAlgorithmEngine.EncodeMethodEnum.RC2);
                    break;
                case AlgorithmType.Rijndael:
                    _se = new SymmetricAlgorithmEngine(SymmetricAlgorithmEngine.EncodeMethodEnum.Rijndael);
                    break;
                case AlgorithmType.SHA:
                    _he = new HashAlgorithmEngine(HashAlgorithmEngine.EncodeMethodEnum.SHA);
                    break;
                case AlgorithmType.SHA256:
                    _he = new HashAlgorithmEngine(HashAlgorithmEngine.EncodeMethodEnum.SHA256);
                    break;
                case AlgorithmType.SHA384:
                    _he = new HashAlgorithmEngine(HashAlgorithmEngine.EncodeMethodEnum.SHA384);
                    break;
                case AlgorithmType.SHA512:
                    _he = new HashAlgorithmEngine(HashAlgorithmEngine.EncodeMethodEnum.SHA512);
                    break;
                case AlgorithmType.TripleDES:
                    _se = new SymmetricAlgorithmEngine(SymmetricAlgorithmEngine.EncodeMethodEnum.TripleDES);
                    break;
                case AlgorithmType.Twofish:
                    _se = new SymmetricAlgorithmEngine(SymmetricAlgorithmEngine.EncodeMethodEnum.Twofish);
                    break;
                default:
                    return false;
            }
            return true;
        }

        public class HashAlgorithmEngine
        {
            public enum EncodeMethodEnum : int
            {
                SHA, SHA256, SHA384, SHA512, MD5
            }

            private HashAlgorithm EncodeMethod;

            public HashAlgorithmEngine(HashAlgorithm ServiceProvider)
            {
                EncodeMethod = ServiceProvider;
            }

            public HashAlgorithmEngine(EncodeMethodEnum iSelected)
            {
                switch (iSelected)
                {
                    case EncodeMethodEnum.SHA:
                        EncodeMethod = new SHA1CryptoServiceProvider();
                        break;
                    case EncodeMethodEnum.SHA256:
                        EncodeMethod = new SHA256Managed();
                        break;
                    case EncodeMethodEnum.SHA384:
                        EncodeMethod = new SHA384Managed();
                        break;
                    case EncodeMethodEnum.SHA512:
                        EncodeMethod = new SHA512Managed();
                        break;
                    case EncodeMethodEnum.MD5:
                        EncodeMethod = new MD5CryptoServiceProvider();
                        break;
                }
            }

            public string Encoding(string Source)
            {
                byte[] bytIn = System.Text.ASCIIEncoding.ASCII.GetBytes(Source);

                byte[] bytOut = EncodeMethod.ComputeHash(bytIn);

                // convert into Base64 so that the result can be used in xml
                return System.Convert.ToBase64String(bytOut, 0, bytOut.Length);
            }
        }

        public class SymmetricAlgorithmEngine
        {
            public enum EncodeMethodEnum : int
            {
                DES, RC2, Rijndael, TripleDES, BlowFish, Twofish
            }

            private SymmetricAlgorithm EncodeMethod;

            public SymmetricAlgorithmEngine(SymmetricAlgorithm ServiceProvider)
            {
                EncodeMethod = ServiceProvider;
            }

            public SymmetricAlgorithmEngine(EncodeMethodEnum iSelected)
            {
                switch (iSelected)
                {
                    case EncodeMethodEnum.DES:
                        EncodeMethod = new DESCryptoServiceProvider();
                        break;
                    case EncodeMethodEnum.RC2:
                        EncodeMethod = new RC2CryptoServiceProvider();
                        break;
                    case EncodeMethodEnum.Rijndael:
                        EncodeMethod = new RijndaelManaged();
                        break;
                    case EncodeMethodEnum.TripleDES:
                        EncodeMethod = new TripleDESCryptoServiceProvider();
                        break;
                    case EncodeMethodEnum.BlowFish:
                        EncodeMethod = new BlowfishAlgorithm();
                        EncodeMethod.Mode = CipherMode.CBC;
                        EncodeMethod.KeySize = 40;
                        EncodeMethod.GenerateKey();
                        EncodeMethod.GenerateIV();
                        break;
                    case EncodeMethodEnum.Twofish:
                        EncodeMethod = new Twofish();
                        EncodeMethod.Mode = CipherMode.CBC;
                        EncodeMethod.GenerateKey();
                        EncodeMethod.GenerateIV();
                        break;

                }
            }

            private byte[] getValidKey(string Key)
            {
                string sTemp;
                if (EncodeMethod.LegalKeySizes.Length > 0)
                {
                    int lessSize = 0, moreSize = EncodeMethod.LegalKeySizes[0].MinSize;
                    // key sizes are in bits

                    while (Key.Length * 8 > moreSize &&
                           EncodeMethod.LegalKeySizes[0].SkipSize > 0 &&
                           moreSize < EncodeMethod.LegalKeySizes[0].MaxSize)
                    {
                        lessSize = moreSize;
                        moreSize += EncodeMethod.LegalKeySizes[0].SkipSize;
                    }

                    if (Key.Length * 8 > moreSize)
                        sTemp = Key.Substring(0, (moreSize / 8));
                    else
                        sTemp = Key.PadRight(moreSize / 8, ' ');
                }
                else
                    sTemp = Key;
                // convert the secret key to byte array
                return ASCIIEncoding.ASCII.GetBytes(sTemp);
            }

            private byte[] getValidIV(String InitVector, int ValidLength)
            {
                if (InitVector.Length > ValidLength)
                {
                    return ASCIIEncoding.ASCII.GetBytes(InitVector.Substring(0, ValidLength));
                }
                else
                {
                    return ASCIIEncoding.ASCII.GetBytes(InitVector.PadRight(ValidLength, ' '));
                }
            }

            public static string BufToStr(byte[] buf)
            {
                StringBuilder result = new StringBuilder(buf.Length * 3);

                for (int nI = 0, nC = buf.Length; nI < nC; nI++)
                {
                    if (0 < nI) result.Append(' ');
                    result.Append(buf[nI].ToString("x2"));
                }
                return result.ToString();
            }

            public string Encrypting(string Source, string Key)
            {
                if (Source == null || Key == null || Source.Length == 0 || Key.Length == 0)
                    return null;

                if (EncodeMethod == null) return "Under Construction";

                long lLen;
                int nRead, nReadTotal;
                byte[] buf = new byte[3];
                byte[] srcData;
                byte[] encData;
                System.IO.MemoryStream sin;
                System.IO.MemoryStream sout;
                CryptoStream encStream;

                srcData = System.Text.ASCIIEncoding.ASCII.GetBytes(Source);
                sin = new MemoryStream();
                sin.Write(srcData, 0, srcData.Length);
                sin.Position = 0;
                sout = new MemoryStream();

                EncodeMethod.Key = getValidKey(Key);
                EncodeMethod.IV = getValidIV(Key, EncodeMethod.IV.Length);

                encStream = new CryptoStream(sout,
                    EncodeMethod.CreateEncryptor(),
                    CryptoStreamMode.Write);
                lLen = sin.Length;
                nReadTotal = 0;
                while (nReadTotal < lLen)
                {
                    nRead = sin.Read(buf, 0, buf.Length);
                    encStream.Write(buf, 0, nRead);
                    nReadTotal += nRead;
                }
                encStream.Close();

                encData = sout.ToArray();
                // create a MemoryStream so that the process can be done without I/O files
                //System.IO.MemoryStream ms = new System.IO.MemoryStream();

                //byte[] bytKey = getValidKey(Key);
                // set the private key
                //EncodeMethod.Key = getValidKey(Key);
                //EncodeMethod.IV = getValidIV(Key, EncodeMethod.IV.Length); 

                // create an Encryptor from the Provider Service instance
                //ICryptoTransform encrypto = EncodeMethod.CreateEncryptor();

                // create Crypto Stream that transforms a stream using the encryption
                //CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);

                // write out encrypted content into MemoryStream
                //cs.Write(bytIn, 0, bytIn.Length);
                //cs.FlushFinalBlock();
                //cs.Close();

                // get the output and trim the '\0' bytes
                //byte[] bytOut = ms.GetBuffer();
                //int i = 0;
                //for (i = 0; i < bytOut.Length; i++)
                //	if (bytOut[i] == 0)
                //		break;

                //byte[] bytOut = ms.ToArray();
                // convert into Base64 so that the result can be used in xml
                return System.Convert.ToBase64String(encData);
                //return System.Convert.ToBase64String(bytOut, 0, i);
            }

            public string Decrypting(string Source, string Key)
            {
                if (Source == null || Key == null || Source.Length == 0 || Key.Length == 0)
                    return null;

                if (EncodeMethod == null) return "Under Construction";

                long lLen;
                int nRead, nReadTotal;
                byte[] buf = new byte[3];
                byte[] decData;
                byte[] encData;
                System.IO.MemoryStream sin;
                System.IO.MemoryStream sout;
                CryptoStream decStream;

                encData = System.Convert.FromBase64String(Source);
                sin = new MemoryStream(encData);
                sout = new MemoryStream();

                EncodeMethod.Key = getValidKey(Key);
                EncodeMethod.IV = getValidIV(Key, EncodeMethod.IV.Length);

                decStream = new CryptoStream(sin,
                    EncodeMethod.CreateDecryptor(),
                    CryptoStreamMode.Read);

                lLen = sin.Length;
                nReadTotal = 0;
                while (nReadTotal < lLen)
                {
                    nRead = decStream.Read(buf, 0, buf.Length);
                    if (0 == nRead) break;

                    sout.Write(buf, 0, nRead);
                    nReadTotal += nRead;
                }
                //long n = sout.Length;

                decStream.Close();

                decData = sout.ToArray();

                // convert from Base64 to binary
                //byte[] bytIn = System.Convert.FromBase64String(Source);
                // create a MemoryStream with the input
                //System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);

                // set the private key
                //EncodeMethod.Key = getValidKey(Key);
                //EncodeMethod.IV = getValidIV(Key, EncodeMethod.IV.Length);

                // create a Decryptor from the Provider Service instance
                //ICryptoTransform encrypto = EncodeMethod.CreateDecryptor();

                // create Crypto Stream that transforms a stream using the decryption
                //CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);

                // read out the result from the Crypto Stream
                //System.IO.StreamReader sr = new System.IO.StreamReader( decStream );
                //string result = sr.ReadToEnd();
                //decStream.Close();
                //sr.Close();


                ASCIIEncoding ascEnc = new ASCIIEncoding();
                return ascEnc.GetString(decData);

                //return n.ToString();
            }

        }
    }
}

namespace Twofish_NET
{
    class en
    {
    }

    /// <summary>
    /// Summary description for Twofish encryption algorithm of which more information can be found at http://www.counterpane.com/twofish.html. 
    /// This is based on the MS cryptographic framework and can therefore be used in place of the RijndaelManaged classes
    /// provided by MS in System.Security.Cryptography and the other related classes
    /// </summary>
    public sealed class Twofish : SymmetricAlgorithm
    {
        /// <summary>
        /// This is the Twofish constructor.
        /// </summary>
        public Twofish()
        {
            this.LegalKeySizesValue = new KeySizes[] { new KeySizes(128, 256, 64) }; // this allows us to have 128,192,256 key sizes

            this.LegalBlockSizesValue = new KeySizes[] { new KeySizes(128, 128, 0) }; // this is in bits - typical of MS - always 16 bytes

            this.BlockSize = 128; // set this to 16 bytes we cannot have any other value
            this.KeySize = 128; // in bits - this can be changed to 128,192,256

            this.Padding = PaddingMode.Zeros;

            this.Mode = CipherMode.ECB;

        }

        /// <summary>
        /// Creates an object that supports ICryptoTransform that can be used to encrypt data using the Twofish encryption algorithm.
        /// </summary>
        /// <param name="key">A byte array that contains a key. The length of this key should be equal to the KeySize property</param>
        /// <param name="iv">A byte array that contains an initialization vector. The length of this IV should be equal to the BlockSize property</param>
        public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
        {
            Key = key; // this appears to make a new copy

            if (Mode == CipherMode.CBC)
                IV = iv;

            return new TwofishEncryption(KeySize, ref KeyValue, ref IVValue, ModeValue, TwofishBase.EncryptionDirection.Encrypting);
        }

        /// <summary>
        /// Creates an object that supports ICryptoTransform that can be used to decrypt data using the Twofish encryption algorithm.
        /// </summary>
        /// <param name="key">A byte array that contains a key. The length of this key should be equal to the KeySize property</param>
        /// <param name="iv">A byte array that contains an initialization vector. The length of this IV should be equal to the BlockSize property</param>
        public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
        {
            Key = key;

            if (Mode == CipherMode.CBC)
                IV = iv;

            return new TwofishEncryption(KeySize, ref KeyValue, ref IVValue, ModeValue, TwofishBase.EncryptionDirection.Decrypting);
        }

        /// <summary>
        /// Generates a random initialization Vector (IV). 
        /// </summary>
        public override void GenerateIV()
        {
            IV = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        /// <summary>
        /// Generates a random Key. This is only really useful in testing scenarios.
        /// </summary>
        public override void GenerateKey()
        {
            Key = new byte[KeySize / 8];

            // set the array to all 0 - implement a random key generation mechanism later probably based on PRNG
            for (int i = Key.GetLowerBound(0); i < Key.GetUpperBound(0); i++)
            {
                Key[i] = 0;
            }
        }

        /// <summary>
        /// Override the Set method on this property so that we only support CBC and EBC
        /// </summary>
        public override CipherMode Mode
        {
            set
            {
                switch (value)
                {
                    case CipherMode.CBC:
                        break;
                    case CipherMode.ECB:
                        break;
                    default:
                        throw (new CryptographicException("Specified CipherMode is not supported."));
                }
                this.ModeValue = value;
            }
        }

    }

    /// <summary>
    /// Summary description for TwofishBase.
    /// </summary>
    internal class TwofishBase
    {
        public enum EncryptionDirection
        {
            Encrypting,
            Decrypting
        }

        public TwofishBase()
        {
        }

        protected int inputBlockSize = BLOCK_SIZE / 8;
        protected int outputBlockSize = BLOCK_SIZE / 8;

        /*
        +*****************************************************************************
        *
        * Function Name:	f32
        *
        * Function:			Run four bytes through keyed S-boxes and apply MDS matrix
        *
        * Arguments:		x			=	input to f function
        *					k32			=	pointer to key dwords
        *					keyLen		=	total key length (k32 --> keyLey/2 bits)
        *
        * Return:			The output of the keyed permutation applied to x.
        *
        * Notes:
        *	This function is a keyed 32-bit permutation.  It is the major building
        *	block for the Twofish round function, including the four keyed 8x8 
        *	permutations and the 4x4 MDS matrix multiply.  This function is used
        *	both for generating round subkeys and within the round function on the
        *	block being encrypted.  
        *
        *	This version is fairly slow and pedagogical, although a smartcard would
        *	probably perform the operation exactly this way in firmware.   For
        *	ultimate performance, the entire operation can be completed with four
        *	lookups into four 256x32-bit tables, with three dword xors.
        *
        *	The MDS matrix is defined in TABLE.H.  To multiply by Mij, just use the
        *	macro Mij(x).
        *
        -****************************************************************************/
        private static uint f32(uint x, ref uint[] k32, int keyLen)
        {
            byte[] b = { b0(x), b1(x), b2(x), b3(x) };

            /* Run each byte thru 8x8 S-boxes, xoring with key byte at each stage. */
            /* Note that each byte goes through a different combination of S-boxes.*/

            //*((DWORD *)b) = Bswap(x);	/* make b[0] = LSB, b[3] = MSB */
            switch (((keyLen + 63) / 64) & 3)
            {
                case 0:		/* 256 bits of key */
                    b[0] = (byte)(P8x8[P_04, b[0]] ^ b0(k32[3]));
                    b[1] = (byte)(P8x8[P_14, b[1]] ^ b1(k32[3]));
                    b[2] = (byte)(P8x8[P_24, b[2]] ^ b2(k32[3]));
                    b[3] = (byte)(P8x8[P_34, b[3]] ^ b3(k32[3]));
                    /* fall thru, having pre-processed b[0]..b[3] with k32[3] */
                    goto case 3;
                case 3:		/* 192 bits of key */
                    b[0] = (byte)(P8x8[P_03, b[0]] ^ b0(k32[2]));
                    b[1] = (byte)(P8x8[P_13, b[1]] ^ b1(k32[2]));
                    b[2] = (byte)(P8x8[P_23, b[2]] ^ b2(k32[2]));
                    b[3] = (byte)(P8x8[P_33, b[3]] ^ b3(k32[2]));
                    /* fall thru, having pre-processed b[0]..b[3] with k32[2] */
                    goto case 2;
                case 2:		/* 128 bits of key */
                    b[0] = P8x8[P_00, P8x8[P_01, P8x8[P_02, b[0]] ^ b0(k32[1])] ^ b0(k32[0])];
                    b[1] = P8x8[P_10, P8x8[P_11, P8x8[P_12, b[1]] ^ b1(k32[1])] ^ b1(k32[0])];
                    b[2] = P8x8[P_20, P8x8[P_21, P8x8[P_22, b[2]] ^ b2(k32[1])] ^ b2(k32[0])];
                    b[3] = P8x8[P_30, P8x8[P_31, P8x8[P_32, b[3]] ^ b3(k32[1])] ^ b3(k32[0])];
                    break;
            }


            /* Now perform the MDS matrix multiply inline. */
            return (uint)((M00(b[0]) ^ M01(b[1]) ^ M02(b[2]) ^ M03(b[3]))) ^
            (uint)((M10(b[0]) ^ M11(b[1]) ^ M12(b[2]) ^ M13(b[3])) << 8) ^
            (uint)((M20(b[0]) ^ M21(b[1]) ^ M22(b[2]) ^ M23(b[3])) << 16) ^
            (uint)((M30(b[0]) ^ M31(b[1]) ^ M32(b[2]) ^ M33(b[3])) << 24);
        }

        /*
        +*****************************************************************************
        *
        * Function Name:	reKey
        *
        * Function:			Initialize the Twofish key schedule from key32
        *
        * Arguments:		key			=	ptr to keyInstance to be initialized
        *
        * Return:			TRUE on success
        *
        * Notes:
        *	Here we precompute all the round subkeys, although that is not actually
        *	required.  For example, on a smartcard, the round subkeys can 
        *	be generated on-the-fly	using f32()
        *
        -****************************************************************************/
        protected bool reKey(int keyLen, ref uint[] key32)
        {
            int i, k64Cnt;
            keyLength = keyLen;
            rounds = numRounds[(keyLen - 1) / 64];
            int subkeyCnt = ROUND_SUBKEYS + 2 * rounds;
            uint A, B;
            uint[] k32e = new uint[MAX_KEY_BITS / 64];
            uint[] k32o = new uint[MAX_KEY_BITS / 64]; /* even/odd key dwords */

            k64Cnt = (keyLen + 63) / 64;		/* round up to next multiple of 64 bits */
            for (i = 0; i < k64Cnt; i++)
            {						/* split into even/odd key dwords */
                k32e[i] = key32[2 * i];
                k32o[i] = key32[2 * i + 1];
                /* compute S-box keys using (12,8) Reed-Solomon code over GF(256) */
                sboxKeys[k64Cnt - 1 - i] = RS_MDS_Encode(k32e[i], k32o[i]); /* reverse order */
            }

            for (i = 0; i < subkeyCnt / 2; i++)					/* compute round subkeys for PHT */
            {
                A = f32((uint)(i * SK_STEP), ref k32e, keyLen);	/* A uses even key dwords */
                B = f32((uint)(i * SK_STEP + SK_BUMP), ref k32o, keyLen);	/* B uses odd  key dwords */
                B = ROL(B, 8);
                subKeys[2 * i] = A + B;			/* combine with a PHT */
                subKeys[2 * i + 1] = ROL(A + 2 * B, SK_ROTL);
            }

            return true;
        }

        protected void blockDecrypt(ref uint[] x)
        {
            uint t0, t1;
            uint[] xtemp = new uint[4];

            if (cipherMode == CipherMode.CBC)
            {
                x.CopyTo(xtemp, 0);
            }

            for (int i = 0; i < BLOCK_SIZE / 32; i++)	/* copy in the block, add whitening */
                x[i] ^= subKeys[OUTPUT_WHITEN + i];

            for (int r = rounds - 1; r >= 0; r--)			/* main Twofish decryption loop */
            {
                t0 = f32(x[0], ref sboxKeys, keyLength);
                t1 = f32(ROL(x[1], 8), ref sboxKeys, keyLength);

                x[2] = ROL(x[2], 1);
                x[2] ^= t0 + t1 + subKeys[ROUND_SUBKEYS + 2 * r]; /* PHT, round keys */
                x[3] ^= t0 + 2 * t1 + subKeys[ROUND_SUBKEYS + 2 * r + 1];
                x[3] = ROR(x[3], 1);

                if (r > 0)									/* unswap, except for last round */
                {
                    t0 = x[0]; x[0] = x[2]; x[2] = t0;
                    t1 = x[1]; x[1] = x[3]; x[3] = t1;
                }
            }

            for (int i = 0; i < BLOCK_SIZE / 32; i++)	/* copy out, with whitening */
            {
                x[i] ^= subKeys[INPUT_WHITEN + i];
                if (cipherMode == CipherMode.CBC)
                {
                    x[i] ^= IV[i];
                    IV[i] = xtemp[i];
                }
            }
        }

        protected void blockEncrypt(ref uint[] x)
        {
            uint t0, t1, tmp;

            for (int i = 0; i < BLOCK_SIZE / 32; i++)	/* copy in the block, add whitening */
            {
                x[i] ^= subKeys[INPUT_WHITEN + i];
                if (cipherMode == CipherMode.CBC)
                    x[i] ^= IV[i];
            }

            for (int r = 0; r < rounds; r++)			/* main Twofish encryption loop */ // 16==rounds
            {
#if FEISTEL
				t0	 = f32(ROR(x[0],  (r+1)/2),ref sboxKeys,keyLength);
				t1	 = f32(ROL(x[1],8+(r+1)/2),ref sboxKeys,keyLength);
											/* PHT, round keys */
				x[2]^= ROL(t0 +   t1 + subKeys[ROUND_SUBKEYS+2*r  ], r    /2);
				x[3]^= ROR(t0 + 2*t1 + subKeys[ROUND_SUBKEYS+2*r+1],(r+2) /2);

#else
                t0 = f32(x[0], ref sboxKeys, keyLength);
                t1 = f32(ROL(x[1], 8), ref sboxKeys, keyLength);

                x[3] = ROL(x[3], 1);
                x[2] ^= t0 + t1 + subKeys[ROUND_SUBKEYS + 2 * r]; /* PHT, round keys */
                x[3] ^= t0 + 2 * t1 + subKeys[ROUND_SUBKEYS + 2 * r + 1];
                x[2] = ROR(x[2], 1);

#endif
                if (r < rounds - 1)						/* swap for next round */
                {
                    tmp = x[0]; x[0] = x[2]; x[2] = tmp;
                    tmp = x[1]; x[1] = x[3]; x[3] = tmp;
                }
            }
#if FEISTEL
			x[0] = ROR(x[0],8);                     /* "final permutation" */
			x[1] = ROL(x[1],8);
			x[2] = ROR(x[2],8);
			x[3] = ROL(x[3],8);
#endif
            for (int i = 0; i < BLOCK_SIZE / 32; i++)	/* copy out, with whitening */
            {
                x[i] ^= subKeys[OUTPUT_WHITEN + i];
                if (cipherMode == CipherMode.CBC)
                {
                    IV[i] = x[i];
                }
            }

        }

        private int[] numRounds = { 0, ROUNDS_128, ROUNDS_192, ROUNDS_256 };

        /*
        +*****************************************************************************
        *
        * Function Name:	RS_MDS_Encode
        *
        * Function:			Use (12,8) Reed-Solomon code over GF(256) to produce
        *					a key S-box dword from two key material dwords.
        *
        * Arguments:		k0	=	1st dword
        *					k1	=	2nd dword
        *
        * Return:			Remainder polynomial generated using RS code
        *
        * Notes:
        *	Since this computation is done only once per reKey per 64 bits of key,
        *	the performance impact of this routine is imperceptible. The RS code
        *	chosen has "simple" coefficients to allow smartcard/hardware implementation
        *	without lookup tables.
        *
        -****************************************************************************/
        static private uint RS_MDS_Encode(uint k0, uint k1)
        {
            uint i, j;
            uint r;

            for (i = r = 0; i < 2; i++)
            {
                r ^= (i > 0) ? k0 : k1;			/* merge in 32 more key bits */
                for (j = 0; j < 4; j++)			/* shift one byte at a time */
                    RS_rem(ref r);
            }
            return r;
        }

        protected uint[] sboxKeys = new uint[MAX_KEY_BITS / 64];	/* key bits used for S-boxes */
        protected uint[] subKeys = new uint[TOTAL_SUBKEYS];		/* round subkeys, input/output whitening bits */
        protected uint[] Key = { 0, 0, 0, 0, 0, 0, 0, 0 };				//new int[MAX_KEY_BITS/32];
        protected uint[] IV = { 0, 0, 0, 0 };						// this should be one block size
        private int keyLength;
        private int rounds;
        protected CipherMode cipherMode = CipherMode.ECB;


        #region These are all the definitions that were found in AES.H
        static private readonly int BLOCK_SIZE = 128;	/* number of bits per block */
        static private readonly int MAX_ROUNDS = 16;	/* max # rounds (for allocating subkey array) */
        static private readonly int ROUNDS_128 = 16;	/* default number of rounds for 128-bit keys*/
        static private readonly int ROUNDS_192 = 16;	/* default number of rounds for 192-bit keys*/
        static private readonly int ROUNDS_256 = 16;	/* default number of rounds for 256-bit keys*/
        static private readonly int MAX_KEY_BITS = 256;	/* max number of bits of key */
        //static private readonly int MIN_KEY_BITS = 128;	/* min number of bits of key (zero pad) */

        //#define		VALID_SIG	 0x48534946	/* initialization signature ('FISH') */
        //#define		MCT_OUTER			400	/* MCT outer loop */
        //#define		MCT_INNER		  10000	/* MCT inner loop */
        //#define		REENTRANT			  1	/* nonzero forces reentrant code (slightly slower) */

        static private readonly int INPUT_WHITEN = 0;	/* subkey array indices */
        static private readonly int OUTPUT_WHITEN = (INPUT_WHITEN + BLOCK_SIZE / 32);
        static private readonly int ROUND_SUBKEYS = (OUTPUT_WHITEN + BLOCK_SIZE / 32);	/* use 2 * (# rounds) */
        static private readonly int TOTAL_SUBKEYS = (ROUND_SUBKEYS + 2 * MAX_ROUNDS);


        #endregion

        #region These are all the definitions that were found in TABLE.H that we need
        /* for computing subkeys */
        static private readonly uint SK_STEP = 0x02020202u;
        static private readonly uint SK_BUMP = 0x01010101u;
        static private readonly int SK_ROTL = 9;

        /* Reed-Solomon code parameters: (12,8) reversible code
        g(x) = x**4 + (a + 1/a) x**3 + a x**2 + (a + 1/a) x + 1
        where a = primitive root of field generator 0x14D */
        static private readonly uint RS_GF_FDBK = 0x14D;		/* field generator */
        static private void RS_rem(ref uint x)
        {
            byte b = (byte)(x >> 24);
            // TODO: maybe change g2 and g3 to bytes			 
            uint g2 = (uint)(((b << 1) ^ (((b & 0x80) == 0x80) ? RS_GF_FDBK : 0)) & 0xFF);
            uint g3 = (uint)(((b >> 1) & 0x7F) ^ (((b & 1) == 1) ? RS_GF_FDBK >> 1 : 0) ^ g2);
            x = (x << 8) ^ (g3 << 24) ^ (g2 << 16) ^ (g3 << 8) ^ b;
        }

        /*	Macros for the MDS matrix
        *	The MDS matrix is (using primitive polynomial 169):
        *      01  EF  5B  5B
        *      5B  EF  EF  01
        *      EF  5B  01  EF
        *      EF  01  EF  5B
        *----------------------------------------------------------------
        * More statistical properties of this matrix (from MDS.EXE output):
        *
        * Min Hamming weight (one byte difference) =  8. Max=26.  Total =  1020.
        * Prob[8]:      7    23    42    20    52    95    88    94   121   128    91
        *             102    76    41    24     8     4     1     3     0     0     0
        * Runs[8]:      2     4     5     6     7     8     9    11
        * MSBs[8]:      1     4    15     8    18    38    40    43
        * HW= 8: 05040705 0A080E0A 14101C14 28203828 50407050 01499101 A080E0A0 
        * HW= 9: 04050707 080A0E0E 10141C1C 20283838 40507070 80A0E0E0 C6432020 07070504 
        *        0E0E0A08 1C1C1410 38382820 70705040 E0E0A080 202043C6 05070407 0A0E080E 
        *        141C101C 28382038 50704070 A0E080E0 4320C620 02924B02 089A4508 
        * Min Hamming weight (two byte difference) =  3. Max=28.  Total = 390150.
        * Prob[3]:      7    18    55   149   270   914  2185  5761 11363 20719 32079
        *           43492 51612 53851 52098 42015 31117 20854 11538  6223  2492  1033
        * MDS OK, ROR:   6+  7+  8+  9+ 10+ 11+ 12+ 13+ 14+ 15+ 16+
        *               17+ 18+ 19+ 20+ 21+ 22+ 23+ 24+ 25+ 26+
        */
        static private readonly int MDS_GF_FDBK = 0x169;	/* primitive polynomial for GF(256)*/
        static private int LFSR1(int x)
        {
            return (((x) >> 1) ^ ((((x) & 0x01) == 0x01) ? MDS_GF_FDBK / 2 : 0));
        }

        static private int LFSR2(int x)
        {
            return (((x) >> 2) ^ ((((x) & 0x02) == 0x02) ? MDS_GF_FDBK / 2 : 0) ^
                ((((x) & 0x01) == 0x01) ? MDS_GF_FDBK / 4 : 0));
        }

        // TODO: not the most efficient use of code but it allows us to update the code a lot quicker we can possibly optimize this code once we have got it all working
        static private int Mx_1(int x)
        {
            return x; /* force result to int so << will work */
        }

        static private int Mx_X(int x)
        {
            return x ^ LFSR2(x);	/* 5B */
        }

        static private int Mx_Y(int x)
        {
            return x ^ LFSR1(x) ^ LFSR2(x);	/* EF */
        }

        static private int M00(int x)
        {
            return Mul_1(x);
        }
        static private int M01(int x)
        {
            return Mul_Y(x);
        }
        static private int M02(int x)
        {
            return Mul_X(x);
        }
        static private int M03(int x)
        {
            return Mul_X(x);
        }

        static private int M10(int x)
        {
            return Mul_X(x);
        }
        static private int M11(int x)
        {
            return Mul_Y(x);
        }
        static private int M12(int x)
        {
            return Mul_Y(x);
        }
        static private int M13(int x)
        {
            return Mul_1(x);
        }

        static private int M20(int x)
        {
            return Mul_Y(x);
        }
        static private int M21(int x)
        {
            return Mul_X(x);
        }
        static private int M22(int x)
        {
            return Mul_1(x);
        }
        static private int M23(int x)
        {
            return Mul_Y(x);
        }

        static private int M30(int x)
        {
            return Mul_Y(x);
        }
        static private int M31(int x)
        {
            return Mul_1(x);
        }
        static private int M32(int x)
        {
            return Mul_Y(x);
        }
        static private int M33(int x)
        {
            return Mul_X(x);
        }

        static private int Mul_1(int x)
        {
            return Mx_1(x);
        }
        static private int Mul_X(int x)
        {
            return Mx_X(x);
        }
        static private int Mul_Y(int x)
        {
            return Mx_Y(x);
        }
        /*	Define the fixed p0/p1 permutations used in keyed S-box lookup.  
            By changing the following constant definitions for P_ij, the S-boxes will
            automatically get changed in all the Twofish source code. Note that P_i0 is
            the "outermost" 8x8 permutation applied.  See the f32() function to see
            how these constants are to be  used.
        */
        static private readonly int P_00 = 1;					/* "outermost" permutation */
        static private readonly int P_01 = 0;
        static private readonly int P_02 = 0;
        static private readonly int P_03 = (P_01 ^ 1);			/* "extend" to larger key sizes */
        static private readonly int P_04 = 1;

        static private readonly int P_10 = 0;
        static private readonly int P_11 = 0;
        static private readonly int P_12 = 1;
        static private readonly int P_13 = (P_11 ^ 1);
        static private readonly int P_14 = 0;

        static private readonly int P_20 = 1;
        static private readonly int P_21 = 1;
        static private readonly int P_22 = 0;
        static private readonly int P_23 = (P_21 ^ 1);
        static private readonly int P_24 = 0;

        static private readonly int P_30 = 0;
        static private readonly int P_31 = 1;
        static private readonly int P_32 = 1;
        static private readonly int P_33 = (P_31 ^ 1);
        static private readonly int P_34 = 1;

        /* fixed 8x8 permutation S-boxes */

        /***********************************************************************
        *  07:07:14  05/30/98  [4x4]  TestCnt=256. keySize=128. CRC=4BD14D9E.
        * maxKeyed:  dpMax = 18. lpMax =100. fixPt =  8. skXor =  0. skDup =  6. 
        * log2(dpMax[ 6..18])=   --- 15.42  1.33  0.89  4.05  7.98 12.05
        * log2(lpMax[ 7..12])=  9.32  1.01  1.16  4.23  8.02 12.45
        * log2(fixPt[ 0.. 8])=  1.44  1.44  2.44  4.06  6.01  8.21 11.07 14.09 17.00
        * log2(skXor[ 0.. 0])
        * log2(skDup[ 0.. 6])=   ---  2.37  0.44  3.94  8.36 13.04 17.99
        ***********************************************************************/
        static private byte[,] P8x8 = 
		{
			/*  p0:   */
			/*  dpMax      = 10.  lpMax      = 64.  cycleCnt=   1  1  1  0.         */
			/* 817D6F320B59ECA4.ECB81235F4A6709D.BA5E6D90C8F32471.D7F4126E9B3085CA. */
			/* Karnaugh maps:
			*  0111 0001 0011 1010. 0001 1001 1100 1111. 1001 1110 0011 1110. 1101 0101 1111 1001. 
			*  0101 1111 1100 0100. 1011 0101 0010 0000. 0101 1000 1100 0101. 1000 0111 0011 0010. 
			*  0000 1001 1110 1101. 1011 1000 1010 0011. 0011 1001 0101 0000. 0100 0010 0101 1011. 
			*  0111 0100 0001 0110. 1000 1011 1110 1001. 0011 0011 1001 1101. 1101 0101 0000 1100. 
			*/
				{
				0xA9, 0x67, 0xB3, 0xE8, 0x04, 0xFD, 0xA3, 0x76, 
				0x9A, 0x92, 0x80, 0x78, 0xE4, 0xDD, 0xD1, 0x38, 
				0x0D, 0xC6, 0x35, 0x98, 0x18, 0xF7, 0xEC, 0x6C, 
				0x43, 0x75, 0x37, 0x26, 0xFA, 0x13, 0x94, 0x48, 
				0xF2, 0xD0, 0x8B, 0x30, 0x84, 0x54, 0xDF, 0x23, 
				0x19, 0x5B, 0x3D, 0x59, 0xF3, 0xAE, 0xA2, 0x82, 
				0x63, 0x01, 0x83, 0x2E, 0xD9, 0x51, 0x9B, 0x7C, 
				0xA6, 0xEB, 0xA5, 0xBE, 0x16, 0x0C, 0xE3, 0x61, 
				0xC0, 0x8C, 0x3A, 0xF5, 0x73, 0x2C, 0x25, 0x0B, 
				0xBB, 0x4E, 0x89, 0x6B, 0x53, 0x6A, 0xB4, 0xF1, 
				0xE1, 0xE6, 0xBD, 0x45, 0xE2, 0xF4, 0xB6, 0x66, 
				0xCC, 0x95, 0x03, 0x56, 0xD4, 0x1C, 0x1E, 0xD7, 
				0xFB, 0xC3, 0x8E, 0xB5, 0xE9, 0xCF, 0xBF, 0xBA, 
				0xEA, 0x77, 0x39, 0xAF, 0x33, 0xC9, 0x62, 0x71, 
				0x81, 0x79, 0x09, 0xAD, 0x24, 0xCD, 0xF9, 0xD8, 
				0xE5, 0xC5, 0xB9, 0x4D, 0x44, 0x08, 0x86, 0xE7, 
				0xA1, 0x1D, 0xAA, 0xED, 0x06, 0x70, 0xB2, 0xD2, 
				0x41, 0x7B, 0xA0, 0x11, 0x31, 0xC2, 0x27, 0x90, 
				0x20, 0xF6, 0x60, 0xFF, 0x96, 0x5C, 0xB1, 0xAB, 
				0x9E, 0x9C, 0x52, 0x1B, 0x5F, 0x93, 0x0A, 0xEF, 
				0x91, 0x85, 0x49, 0xEE, 0x2D, 0x4F, 0x8F, 0x3B, 
				0x47, 0x87, 0x6D, 0x46, 0xD6, 0x3E, 0x69, 0x64, 
				0x2A, 0xCE, 0xCB, 0x2F, 0xFC, 0x97, 0x05, 0x7A, 
				0xAC, 0x7F, 0xD5, 0x1A, 0x4B, 0x0E, 0xA7, 0x5A, 
				0x28, 0x14, 0x3F, 0x29, 0x88, 0x3C, 0x4C, 0x02, 
				0xB8, 0xDA, 0xB0, 0x17, 0x55, 0x1F, 0x8A, 0x7D, 
				0x57, 0xC7, 0x8D, 0x74, 0xB7, 0xC4, 0x9F, 0x72, 
				0x7E, 0x15, 0x22, 0x12, 0x58, 0x07, 0x99, 0x34, 
				0x6E, 0x50, 0xDE, 0x68, 0x65, 0xBC, 0xDB, 0xF8, 
				0xC8, 0xA8, 0x2B, 0x40, 0xDC, 0xFE, 0x32, 0xA4, 
				0xCA, 0x10, 0x21, 0xF0, 0xD3, 0x5D, 0x0F, 0x00, 
				0x6F, 0x9D, 0x36, 0x42, 0x4A, 0x5E, 0xC1, 0xE0
			},
			/*  p1:   */
			/*  dpMax      = 10.  lpMax      = 64.  cycleCnt=   2  0  0  1.         */
			/* 28BDF76E31940AC5.1E2B4C376DA5F908.4C75169A0ED82B3F.B951C3DE647F208A. */
			/* Karnaugh maps:
			*  0011 1001 0010 0111. 1010 0111 0100 0110. 0011 0001 1111 0100. 1111 1000 0001 1100. 
			*  1100 1111 1111 1010. 0011 0011 1110 0100. 1001 0110 0100 0011. 0101 0110 1011 1011. 
			*  0010 0100 0011 0101. 1100 1000 1000 1110. 0111 1111 0010 0110. 0000 1010 0000 0011. 
			*  1101 1000 0010 0001. 0110 1001 1110 0101. 0001 0100 0101 0111. 0011 1011 1111 0010. 
			*/
			{
				0x75, 0xF3, 0xC6, 0xF4, 0xDB, 0x7B, 0xFB, 0xC8, 
				0x4A, 0xD3, 0xE6, 0x6B, 0x45, 0x7D, 0xE8, 0x4B, 
				0xD6, 0x32, 0xD8, 0xFD, 0x37, 0x71, 0xF1, 0xE1, 
				0x30, 0x0F, 0xF8, 0x1B, 0x87, 0xFA, 0x06, 0x3F, 
				0x5E, 0xBA, 0xAE, 0x5B, 0x8A, 0x00, 0xBC, 0x9D, 
				0x6D, 0xC1, 0xB1, 0x0E, 0x80, 0x5D, 0xD2, 0xD5, 
				0xA0, 0x84, 0x07, 0x14, 0xB5, 0x90, 0x2C, 0xA3, 
				0xB2, 0x73, 0x4C, 0x54, 0x92, 0x74, 0x36, 0x51, 
				0x38, 0xB0, 0xBD, 0x5A, 0xFC, 0x60, 0x62, 0x96, 
				0x6C, 0x42, 0xF7, 0x10, 0x7C, 0x28, 0x27, 0x8C, 
				0x13, 0x95, 0x9C, 0xC7, 0x24, 0x46, 0x3B, 0x70, 
				0xCA, 0xE3, 0x85, 0xCB, 0x11, 0xD0, 0x93, 0xB8, 
				0xA6, 0x83, 0x20, 0xFF, 0x9F, 0x77, 0xC3, 0xCC, 
				0x03, 0x6F, 0x08, 0xBF, 0x40, 0xE7, 0x2B, 0xE2, 
				0x79, 0x0C, 0xAA, 0x82, 0x41, 0x3A, 0xEA, 0xB9, 
				0xE4, 0x9A, 0xA4, 0x97, 0x7E, 0xDA, 0x7A, 0x17, 
				0x66, 0x94, 0xA1, 0x1D, 0x3D, 0xF0, 0xDE, 0xB3, 
				0x0B, 0x72, 0xA7, 0x1C, 0xEF, 0xD1, 0x53, 0x3E, 
				0x8F, 0x33, 0x26, 0x5F, 0xEC, 0x76, 0x2A, 0x49, 
				0x81, 0x88, 0xEE, 0x21, 0xC4, 0x1A, 0xEB, 0xD9, 
				0xC5, 0x39, 0x99, 0xCD, 0xAD, 0x31, 0x8B, 0x01, 
				0x18, 0x23, 0xDD, 0x1F, 0x4E, 0x2D, 0xF9, 0x48, 
				0x4F, 0xF2, 0x65, 0x8E, 0x78, 0x5C, 0x58, 0x19, 
				0x8D, 0xE5, 0x98, 0x57, 0x67, 0x7F, 0x05, 0x64, 
				0xAF, 0x63, 0xB6, 0xFE, 0xF5, 0xB7, 0x3C, 0xA5, 
				0xCE, 0xE9, 0x68, 0x44, 0xE0, 0x4D, 0x43, 0x69, 
				0x29, 0x2E, 0xAC, 0x15, 0x59, 0xA8, 0x0A, 0x9E, 
				0x6E, 0x47, 0xDF, 0x34, 0x35, 0x6A, 0xCF, 0xDC, 
				0x22, 0xC9, 0xC0, 0x9B, 0x89, 0xD4, 0xED, 0xAB, 
				0x12, 0xA2, 0x0D, 0x52, 0xBB, 0x02, 0x2F, 0xA9, 
				0xD7, 0x61, 0x1E, 0xB4, 0x50, 0x04, 0xF6, 0xC2, 
				0x16, 0x25, 0x86, 0x56, 0x55, 0x09, 0xBE, 0x91
			}
		};
        #endregion

        #region These are all the definitions that were found in PLATFORM.H that we need
        // left rotation
        private static uint ROL(uint x, int n)
        {
            return (((x) << ((n) & 0x1F)) | (x) >> (32 - ((n) & 0x1F)));
        }

        // right rotation
        private static uint ROR(uint x, int n)
        {
            return (((x) >> ((n) & 0x1F)) | ((x) << (32 - ((n) & 0x1F))));
        }

        // first byte
        protected static byte b0(uint x)
        {
            return (byte)(x);//& 0xFF);
        }
        // second byte
        protected static byte b1(uint x)
        {
            return (byte)((x >> 8));// & (0xFF));
        }
        // third byte
        protected static byte b2(uint x)
        {
            return (byte)((x >> 16));// & (0xFF));
        }
        // fourth byte
        protected static byte b3(uint x)
        {
            return (byte)((x >> 24));// & (0xFF));
        }

        #endregion
    }

    /// <summary>
    /// Summary description for TwofishEncryption.
    /// </summary>
    internal class TwofishEncryption : TwofishBase, ICryptoTransform
    {
        public TwofishEncryption(int keyLen, ref byte[] key, ref byte[] iv, CipherMode cMode, EncryptionDirection direction)
        {
            // convert our key into an array of ints
            for (int i = 0; i < key.Length / 4; i++)
            {
                Key[i] = (uint)(key[i * 4 + 3] << 24) | (uint)(key[i * 4 + 2] << 16) | (uint)(key[i * 4 + 1] << 8) | (uint)(key[i * 4 + 0]);
            }

            cipherMode = cMode;

            // we only need to convert our IV if we are using CBC
            if (cipherMode == CipherMode.CBC)
            {
                for (int i = 0; i < 4; i++)
                {
                    IV[i] = (uint)(iv[i * 4 + 3] << 24) | (uint)(iv[i * 4 + 2] << 16) | (uint)(iv[i * 4 + 1] << 8) | (uint)(iv[i * 4 + 0]);
                }
            }

            encryptionDirection = direction;
            reKey(keyLen, ref Key);
        }

        // need to have this method due to IDisposable - just can't think of a reason to use it for in this class
        public void Dispose()
        {
        }


        /// <summary>
        /// Transform a block depending on whether we are encrypting or decrypting
        /// </summary>
        /// <param name="inputBuffer"></param>
        /// <param name="inputOffset"></param>
        /// <param name="inputCount"></param>
        /// <param name="outputBuffer"></param>
        /// <param name="outputOffset"></param>
        /// <returns></returns>
        public int TransformBlock(
            byte[] inputBuffer,
            int inputOffset,
            int inputCount,
            byte[] outputBuffer,
            int outputOffset
            )
        {
            uint[] x = new uint[4];

            // load it up
            for (int i = 0; i < 4; i++)
            {
                x[i] = (uint)(inputBuffer[i * 4 + 3 + inputOffset] << 24) | (uint)(inputBuffer[i * 4 + 2 + inputOffset] << 16) |
                    (uint)(inputBuffer[i * 4 + 1 + inputOffset] << 8) | (uint)(inputBuffer[i * 4 + 0 + inputOffset]);

            }

            if (encryptionDirection == EncryptionDirection.Encrypting)
            {
                blockEncrypt(ref x);
            }
            else
            {
                blockDecrypt(ref x);
            }


            // load it up
            for (int i = 0; i < 4; i++)
            {
                outputBuffer[i * 4 + 0 + outputOffset] = b0(x[i]);
                outputBuffer[i * 4 + 1 + outputOffset] = b1(x[i]);
                outputBuffer[i * 4 + 2 + outputOffset] = b2(x[i]);
                outputBuffer[i * 4 + 3 + outputOffset] = b3(x[i]);
            }


            return inputCount;
        }

        public byte[] TransformFinalBlock(
            byte[] inputBuffer,
            int inputOffset,
            int inputCount
            )
        {
            byte[] result;

            if (inputCount > 0)
            {
                int rest = inputCount % 16;
                int bufsize = inputCount - rest;
                if (rest > 0) bufsize += 16;
                result = new byte[bufsize];
                Array.Copy(inputBuffer, 0, result, 0, inputCount);

                for (int i = inputCount; i < bufsize; i++)
                    result[i] = (byte)0;
                TransformBlock(result, 0, bufsize, result, 0);

            }
            else
            {
                //outputBuffer = new byte[0];
                result = new byte[inputCount]; // the .NET framework doesn't like it if you return null - this calms it down
            }

            return result;
        }

        // not worked out this property yet - placing break points here just don't get caught.
        private bool canReuseTransform = true;
        public bool CanReuseTransform
        {
            get
            {
                return canReuseTransform;
            }
        }

        // I normally set this to false when block encrypting so that I can work on one block at a time
        // but for compression and stream type ciphers this can be set to true so that you get all the data
        private bool canTransformMultipleBlocks = false;
        public bool CanTransformMultipleBlocks
        {
            get
            {
                return canTransformMultipleBlocks;
            }
        }

        public int InputBlockSize
        {
            get
            {
                return inputBlockSize;
            }
        }

        public int OutputBlockSize
        {
            get
            {
                return outputBlockSize;
            }
        }

        private EncryptionDirection encryptionDirection;
    }
}

namespace Blowfish_NET
{

    /// <summary>  
    ///   Blowfish ECB implementation
    /// </summary>
    /// <remarks>
    ///   Use this class to encrypt or decrypt byte arrays or a single
    ///   block with Blowfish in the ECB (Electronic Code Book) mode,
    ///   they key length can be flexible from zero up to 56 bytes.
    /// </remarks>
    public class Blowfish
    {

        /// <summary>
        ///   maximum (and recommended) key size in bytes
        /// </summary>
        public const int MAXKEYLENGTH = 56;

        /// <summary>
        ///   block size in bytes
        /// </summary>
        /// <remarks>
        ///   (please note that data has to be aligned to the block size) 
        /// </remarks>
        public const int BLOCKSIZE = 8;

        const int PBOX_ENTRIES = 18;
        const int SBOX_ENTRIES = 256;

        uint[] m_pbox;
        uint[] m_sbox1;
        uint[] m_sbox2;
        uint[] m_sbox3;
        uint[] m_sbox4;

        int m_nIsWeakKey;

        /// <summary>
        /// to check if the key used is weak, which means that eventually
        /// an attack is easier to apply than simple brute force on keys;
        /// due to the randomness such a case is very unlikely to happen
        /// </summary>
        public bool IsWeakKey
        {
            get
            {
                // (NOTE: for performance reason we don't do the weak key 
                //  check during the initialization, but on demand only)

                if (-1 == m_nIsWeakKey)
                {
                    m_nIsWeakKey = 0;

                    int nI, nJ;
                    for (nI = 0; nI < SBOX_ENTRIES - 1; nI++)
                    {
                        nJ = nI + 1;
                        while (nJ < SBOX_ENTRIES)
                        {
                            if ((m_sbox1[nI] == m_sbox1[nJ]) |
                                (m_sbox2[nI] == m_sbox2[nJ]) |
                                (m_sbox3[nI] == m_sbox3[nJ]) |
                                (m_sbox4[nI] == m_sbox4[nJ])) break;
                            else nJ++;
                        }
                        if (nJ < SBOX_ENTRIES)
                        {
                            m_nIsWeakKey = 1;
                            break;
                        }
                    }
                }

                return (1 == m_nIsWeakKey);
            }
        }

        /// <summary>
        ///   standard constructor
        /// </summary>
        /// <param name="key"> 
        ///   the key material, up to MAXKYELENGTH bytes, oversized material is ignored
        /// </param>
        public Blowfish
            (byte[] key)
        {
            int nI;

            m_pbox = new uint[PBOX_ENTRIES];

            for (nI = 0; nI < PBOX_ENTRIES; nI++)
            {
                m_pbox[nI] = BlowfishTables.pbox_init[nI];
            }

            m_sbox1 = new uint[SBOX_ENTRIES];
            m_sbox2 = new uint[SBOX_ENTRIES];
            m_sbox3 = new uint[SBOX_ENTRIES];
            m_sbox4 = new uint[SBOX_ENTRIES];

            for (nI = 0; nI < SBOX_ENTRIES; nI++)
            {
                m_sbox1[nI] = BlowfishTables.sbox_init_1[nI];
                m_sbox2[nI] = BlowfishTables.sbox_init_2[nI];
                m_sbox3[nI] = BlowfishTables.sbox_init_3[nI];
                m_sbox4[nI] = BlowfishTables.sbox_init_4[nI];
            }

            // xor the key over the p-boxes

            int nLen = key.Length;
            if (nLen == 0) return;
            int nKeyPos = 0;
            uint unBuild = 0;

            for (nI = 0; nI < PBOX_ENTRIES; nI++)
            {
                for (int nJ = 0; nJ < 4; nJ++)
                {
                    unBuild = (unBuild << 8) | key[nKeyPos];

                    if (++nKeyPos == nLen)
                    {
                        nKeyPos = 0;
                    }
                }
                m_pbox[nI] ^= unBuild;
            }


            // encrypt all boxes with the all zero string
            uint unZeroHi = 0;
            uint unZeroLo = 0;

            for (nI = 0; nI < PBOX_ENTRIES; nI += 2)
            {
                BaseEncrypt(ref unZeroHi, ref unZeroLo);
                m_pbox[nI] = unZeroHi;
                m_pbox[nI + 1] = unZeroLo;
            }
            for (nI = 0; nI < SBOX_ENTRIES; nI += 2)
            {
                BaseEncrypt(ref unZeroHi, ref unZeroLo);
                m_sbox1[nI] = unZeroHi;
                m_sbox1[nI + 1] = unZeroLo;
            }
            for (nI = 0; nI < SBOX_ENTRIES; nI += 2)
            {
                BaseEncrypt(ref unZeroHi, ref unZeroLo);
                m_sbox2[nI] = unZeroHi;
                m_sbox2[nI + 1] = unZeroLo;
            }
            for (nI = 0; nI < SBOX_ENTRIES; nI += 2)
            {
                BaseEncrypt(ref unZeroHi, ref unZeroLo);
                m_sbox3[nI] = unZeroHi;
                m_sbox3[nI + 1] = unZeroLo;
            }
            for (nI = 0; nI < SBOX_ENTRIES; nI += 2)
            {
                BaseEncrypt(ref unZeroHi, ref unZeroLo);
                m_sbox4[nI] = unZeroHi;
                m_sbox4[nI + 1] = unZeroLo;
            }

            m_nIsWeakKey = -1;
        }


        /// <summary>
        ///   deletes all internal data structures and invalidates this instance
        /// </summary>
        /// <remarks>
        ///   Call this method as soon as the work with a particular instance is
        ///   done. By this no sensitive translated key material remains. The
        ///   instance is invalid after this call and usage can lead to unexpected
        ///   results.
        /// </remarks> 
        public virtual void Burn()
        {
            int nI;

            for (nI = 0; nI < PBOX_ENTRIES; nI++)
            {
                m_pbox[nI] = 0;
            }

            for (nI = 0; nI < SBOX_ENTRIES; nI++)
            {
                m_sbox1[nI] = m_sbox2[nI] = m_sbox3[nI] = m_sbox4[nI] = 0;
            }
        }



        static readonly byte[] TEST_KEY = { 0x1c, 0x58, 0x7f, 0x1c, 0x13, 0x92, 0x4f, 0xef };
        static readonly uint[] TEST_VECTOR_PLAIN = { 0x30553228, 0x6d6f295a };
        static readonly uint[] TEST_VECTOR_CIPHER = { 0x55cb3774, 0xd13ef201 };


        /// <summary>
        ///   executes a selftest
        /// </summary>
        /// <remarks>
        ///   Call this method to make sure that the instance is able to produce
        ///   valid output according to the specification.
        /// </remarks>
        /// <returns>
        ///   true: selftest passed / false: selftest failed
        /// </returns>
        public static bool SelfTest()
        {
            uint unHi = TEST_VECTOR_PLAIN[0];
            uint unLo = TEST_VECTOR_PLAIN[1];

            Blowfish bf = new Blowfish(TEST_KEY);

            bf.Encrypt(ref unHi, ref unLo);

            if ((unHi != TEST_VECTOR_CIPHER[0]) ||
                (unLo != TEST_VECTOR_CIPHER[1]))
            {
                return false;
            }

            bf.Decrypt(ref unHi, ref unLo);

            if ((unHi != TEST_VECTOR_PLAIN[0]) ||
                (unLo != TEST_VECTOR_PLAIN[1]))
            {
                return false;
            }

            return true;
        }

        protected void BaseEncrypt
            (ref uint unHiRef,
            ref uint unLoRef)
        {
            // copy to local cache (faster)

            uint unHi = unHiRef;
            uint unLo = unLoRef;

            // and use local references, too

            uint[] sbox1 = m_sbox1;
            uint[] sbox2 = m_sbox2;
            uint[] sbox3 = m_sbox3;
            uint[] sbox4 = m_sbox4;

            uint[] pbox = m_pbox;

            // encrypt the block, unrolled loop and odd/even changes to maximize the speed

            unHi ^= pbox[0];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[1];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[2];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[3];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[4];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[5];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[6];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[7];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[8];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[9];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[10];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[11];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[12];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[13];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[14];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[15];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[16];

            // finalize and copy back

            unLoRef = unHi;
            unHiRef = unLo ^ pbox[17];
        }

        /// <summary>
        ///   encrypts a single block
        /// </summary>
        /// <remarks>
        ///   Use this method to encrypt one logical block, which is passed
        ///   as two 32bit halves. If you extract the block from a sequence
        ///   of bytes you have to do it in the network byte order.
        /// </remarks>
        /// <param name="unHiRef">
        ///   reference to the high 32 bits of the block
        /// </param>
        /// <param name="unLoRef">
        ///   reference to the low 32 bits of the block
        /// </param>
        public virtual void Encrypt
            (ref uint unHiRef,
            ref uint unLoRef)
        {
            BaseEncrypt(ref unHiRef, ref unLoRef);
        }


        /// <summary>
        ///   encrypts single bytes
        /// </summary>
        /// <remarks>
        ///   Use this method to encrypt bytes from one array to another one.
        ///   You can also use the same array for input and output. Note that
        ///   the number of bytes must be adjusted to the block size of the
        ///   algorithm. Overlapping bytes will not be encrypted. No check for
        ///   buffer overflows are made.
        /// </remarks>
        /// <param name="dataIn"> input buffer </param>
        /// <param name="dataOut"> output buffer </param>
        /// <param name="nPosIn"> where to start reading in the input buffer </param>
        /// <param name="nPosOut"> where to start writing to the output buffer </param>
        /// <param name="nCount"> number ob bytes to encrypt </param>
        /// <returns>
        ///   number of blocks processed
        /// </returns>
        public int Encrypt
            (byte[] dataIn,
            byte[] dataOut,
            int nPosIn,
            int nPosOut,
            int nCount)
        {
            // count in blocks
            nCount >>= 3;

            for (int nI = 0; nI < nCount; nI++)
            {
                // load the bytes into two 32bit words, which together represent the block

                uint unHi = (((uint)dataIn[nPosIn]) << 24) |
                    (((uint)dataIn[nPosIn + 1]) << 16) |
                    (((uint)dataIn[nPosIn + 2]) << 8) |
                    dataIn[nPosIn + 3];

                uint unLo = (((uint)dataIn[nPosIn + 4]) << 24) |
                    (((uint)dataIn[nPosIn + 5]) << 16) |
                    (((uint)dataIn[nPosIn + 6]) << 8) |
                    dataIn[nPosIn + 7];

                // encrypt that construct

                Encrypt(ref unHi, ref unLo);

                // write the encrypted block back

                dataOut[nPosOut] = (byte)(unHi >> 24);
                dataOut[nPosOut + 1] = (byte)(unHi >> 16);
                dataOut[nPosOut + 2] = (byte)(unHi >> 8);
                dataOut[nPosOut + 3] = (byte)unHi;
                dataOut[nPosOut + 4] = (byte)(unLo >> 24);
                dataOut[nPosOut + 5] = (byte)(unLo >> 16);
                dataOut[nPosOut + 6] = (byte)(unLo >> 8);
                dataOut[nPosOut + 7] = (byte)unLo;

                nPosIn += 8;
                nPosOut += 8;
            }

            return nCount;
        }



        /// <summary>
        ///   decrypts a single block
        /// </summary>
        /// <remarks>
        ///   Use this method to decrypt one logical block, which is passed
        ///   as two 32bit halves. If you extract the block from a sequence
        ///   of bytes you have to do it in the network byte order.
        /// </remarks>
        /// <param name="unHiRef">
        ///   reference to the high 32 bits of the block
        /// </param>
        /// <param name="unLoRef">
        ///   reference to the low 32 bits of the block
        /// </param>
        public virtual void Decrypt
            (ref uint unHiRef,
            ref uint unLoRef)
        {
            // (same procedure and tricks as above)

            uint unHi = unHiRef;
            uint unLo = unLoRef;

            uint[] sbox1 = m_sbox1;
            uint[] sbox2 = m_sbox2;
            uint[] sbox3 = m_sbox3;
            uint[] sbox4 = m_sbox4;

            uint[] pbox = m_pbox;

            unHi ^= pbox[(int)(17)];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[16];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[15];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[14];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[13];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[12];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[11];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[10];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[9];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[8];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[7];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[6];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[5];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[4];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[3];
            unLo ^= (((sbox1[(int)(unHi >> 24)] + sbox2[(int)((unHi >> 16) & 0x0ff)]) ^ sbox3[(int)((unHi >> 8) & 0x0ff)]) + sbox4[(int)(unHi & 0x0ff)]) ^ pbox[2];
            unHi ^= (((sbox1[(int)(unLo >> 24)] + sbox2[(int)((unLo >> 16) & 0x0ff)]) ^ sbox3[(int)((unLo >> 8) & 0x0ff)]) + sbox4[(int)(unLo & 0x0ff)]) ^ pbox[1];

            unLoRef = unHi;
            unHiRef = unLo ^ pbox[0];
        }


        /// <summary>
        ///   decrypts single bytes
        /// </summary>
        /// <remarks>
        ///   Use this method to decrypt bytes from one array to another one.
        ///   You can also use the same array for input and output. Note that
        ///   the number of bytes must be adjusted to the block size of the
        ///   algorithm. Overlapping bytes will not be decrypted. No check for
        ///   buffer overflows are made.
        /// </remarks>
        /// <param name="dataIn"> input buffer </param>
        /// <param name="dataOut"> output buffer </param>
        /// <param name="nPosIn"> where to start reading in the input buffer </param>
        /// <param name="nPosOut"> where to start writing to the output buffer </param>
        /// <param name="nCount"> number ob bytes to decrypt </param>
        /// <returns>
        ///   number of blocks processed
        /// </returns>
        public int Decrypt
            (byte[] dataIn,
            byte[] dataOut,
            int nPosIn,
            int nPosOut,
            int nCount)
        {
            // count in blocks
            nCount >>= 3;

            for (int nI = 0; nI < nCount; nI++)
            {
                // load the bytes into two 32bit words, which together represent the block

                uint unHi = (((uint)dataIn[nPosIn]) << 24) |
                    (((uint)dataIn[nPosIn + 1]) << 16) |
                    (((uint)dataIn[nPosIn + 2]) << 8) |
                    dataIn[nPosIn + 3];

                uint unLo = (((uint)dataIn[nPosIn + 4]) << 24) |
                    (((uint)dataIn[nPosIn + 5]) << 16) |
                    (((uint)dataIn[nPosIn + 6]) << 8) |
                    dataIn[nPosIn + 7];

                // encrypt that construct

                Decrypt(ref unHi, ref unLo);

                // write the encrypted block back

                dataOut[nPosOut] = (byte)(unHi >> 24);
                dataOut[nPosOut + 1] = (byte)(unHi >> 16);
                dataOut[nPosOut + 2] = (byte)(unHi >> 8);
                dataOut[nPosOut + 3] = (byte)unHi;
                dataOut[nPosOut + 4] = (byte)(unLo >> 24);
                dataOut[nPosOut + 5] = (byte)(unLo >> 16);
                dataOut[nPosOut + 6] = (byte)(unLo >> 8);
                dataOut[nPosOut + 7] = (byte)unLo;

                nPosIn += 8;
                nPosOut += 8;
            }

            return nCount;
        }
    }
}

namespace Blowfish_NET
{
    public class BlowfishAlgorithm : SymmetricAlgorithm, ICryptoTransform
    {
        // in factory mode the Blowfish instances are always null,
        // they get only initialized in transformation mode

        Blowfish m_bf;
        BlowfishCBC m_bfc;
        bool m_blIsEncryptor;


        // factory settings

        RNGCryptoServiceProvider m_rng;

        /// <summary>
        /// constructor
        /// </summary>
        public BlowfishAlgorithm()
            : base()
        {
            m_bf = null;
            m_bfc = null;

            // FIXME: are we supposed to create a default key and IV?
            IVValue = null;
            KeyValue = null;
            KeySizeValue = Blowfish.MAXKEYLENGTH * 8;

            LegalBlockSizesValue = new KeySizes[1];
            LegalBlockSizesValue[0] = new KeySizes(BlockSize, BlockSize, 8);

            LegalKeySizesValue = new KeySizes[1];
            LegalKeySizesValue[0] = new KeySizes(0, Blowfish.MAXKEYLENGTH * 8, 8);

            ModeValue = CipherMode.ECB;

            m_rng = null;
        }

        BlowfishAlgorithm
            (
            byte[] key,
            byte[] iv,
            bool blCBC,
            bool blIsEncryptor
            )
        {
            if (null == key) GenerateKey(); else Key = key;

            if (blCBC)
            {
                if (null == iv) GenerateIV(); else IV = iv;

                m_bf = null;
                m_bfc = new BlowfishCBC(KeyValue, IVValue);
            }
            else
            {
                m_bf = new Blowfish(KeyValue);
                m_bfc = null;
            }

            m_blIsEncryptor = blIsEncryptor;
        }


        /// <summary>
        /// checks if a key is weak (and perhaps shouldn't be used)
        /// </summary>
        /// <param name="key">
        /// the key material to test against
        /// </param>
        /// <returns>
        /// true: key is "weak" / false: key passed the test
        /// </returns>
        public static bool IsWeakKey
            (byte[] key)
        {
            BlowfishAlgorithm bfAlg = new BlowfishAlgorithm(key, null, false, true);

            return bfAlg.m_bf.IsWeakKey;
        }


        // SymmetricAlgorithm ...


        /// <summary>
        /// the Blowfish block size, can only be set to the same value
        /// </summary>
        public override int BlockSize
        {
            get
            {
                return Blowfish.BLOCKSIZE * 8;
            }
            set
            {
                // (we only support 64bit block sizes, although Blowfish is
                //  also thinkable with 128bit blocks or even more)
                if (value != Blowfish.BLOCKSIZE * 8)
                {
                    throw new CryptographicException("illegal blocksize");
                }
            }
        }

        /// <summary>
        /// the initialization vector, used in the factory
        /// </summary>
        public override byte[] IV
        {
            get
            {
                return IVValue;
            }
            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length != Blowfish.BLOCKSIZE)
                {
                    throw new CryptographicException("illegal IV length");
                }
                IVValue = value;
            }
        }

        /// <summary>
        /// the key, used in the factory
        /// </summary>
        public override byte[] Key
        {
            get
            {
                return KeyValue;
            }
            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("key cannot be null");
                }
                // FIXME: according to the documentation we don't validate the
                //        key, can this be correct? additionally it is confusing
                //        because the key size can actually be changed, so what
                //        happens then to the key material already set?
                KeyValue = value;
            }
        }

        /// <summary>
        /// the key length (for auto generation only)
        /// </summary>
        public override int KeySize
        {
            get
            {
                return KeySizeValue;
            }
            set
            {
                KeySizes ks = LegalKeySizes[0];
                if ((0 != (value % ks.SkipSize)) ||
                    (value > ks.MaxSize) ||
                    (value < ks.MinSize))
                {
                    throw new CryptographicException("invalid key size");
                }
                KeySizeValue = value;
            }
        }

        public override KeySizes[] LegalBlockSizes
        {
            get
            {
                return LegalBlockSizesValue;
            }
        }

        public override KeySizes[] LegalKeySizes
        {
            get
            {
                return LegalKeySizesValue;
            }
        }

        public override CipherMode Mode
        {
            get
            {
                return ModeValue;
            }
            set
            {
                // FIXME: we only support ECB and CBC, so is it ok
                //        to raise an exception even if the requested
                //        mode itself is a valid one?
                if (value != CipherMode.CBC &&
                    value != CipherMode.ECB)
                {
                    throw new CryptographicException("only ECB and CBC are supported");
                }
                ModeValue = value;
            }
        }

        // the factory methods are just simple mappings to the private constructors

        public override ICryptoTransform CreateEncryptor
            (
            byte[] key,
            byte[] iv
            )
        {
            BlowfishAlgorithm result = new BlowfishAlgorithm(
                key,
                iv,
                (CipherMode.CBC == ModeValue),
                true);

            result.Padding = Padding;
            return result;
        }

        public override ICryptoTransform CreateDecryptor
            (
            byte[] key,
            byte[] iv
            )
        {
            BlowfishAlgorithm result = new BlowfishAlgorithm(
                key,
                iv,
                (CipherMode.CBC == ModeValue),
                false);

            result.Padding = Padding;
            return result;
        }

        // FIXME: is our generator strategy here good enough?
        //        (and why does the base class actually not offer a decent default?)

        public override void GenerateKey()
        {
            if (null == m_rng) m_rng = new RNGCryptoServiceProvider();

            KeyValue = new byte[KeySizeValue / 8];
            m_rng.GetBytes(KeyValue);
        }

        public override void GenerateIV()
        {
            if (null == m_rng) m_rng = new RNGCryptoServiceProvider();

            IVValue = new byte[Blowfish.BLOCKSIZE];
            m_rng.GetBytes(IVValue);
        }

        // ICryptoTransform ...

        public bool CanReuseTransform
        {
            get
            {
                return true;
            }
        }

        public bool CanTransformMultipleBlocks
        {
            get
            {
                return true;
            }
        }

        public int InputBlockSize
        {
            get
            {
                return Blowfish.BLOCKSIZE;
            }
        }

        public int OutputBlockSize
        {
            get
            {
                return Blowfish.BLOCKSIZE;
            }
        }

        public int TransformBlock
            (
            byte[] bufIn,
            int nOfsIn,
            int nCount,
            byte[] bufOut,
            int nOfsOut
            )
        {
            // NOTE: we assume that the caller understands the meaning of
            //	     this method and that only even byte boundaries are
            //       given, thus we do not cache any data left internally

            int nResult = 0;

            if (null != m_bfc)
            {
                if (m_blIsEncryptor)
                {
                    nResult = m_bfc.Encrypt(bufIn, bufOut, nOfsIn, nOfsOut, nCount);
                }
                else
                {
                    nResult = m_bfc.Decrypt(bufIn, bufOut, nOfsIn, nOfsOut, nCount);
                }
            }
            else if (null != m_bf)
            {
                if (m_blIsEncryptor)
                {
                    nResult = m_bf.Encrypt(bufIn, bufOut, nOfsIn, nOfsOut, nCount);
                }
                else
                {
                    nResult = m_bf.Decrypt(bufIn, bufOut, nOfsIn, nOfsOut, nCount);
                }
            }
            else
            {
                nResult = 0;
            }

            return nResult * Blowfish.BLOCKSIZE;
        }

        public byte[] TransformFinalBlock
            (
            byte[] inBuf,
            int nOfs,
            int nCount
            )
        {
            byte[] result;

            if (m_blIsEncryptor)
            {
                // we need to take over whatever we got, pad it with the right
                // scheme and then encrypt or decrypt it

                int nRest = nCount % Blowfish.BLOCKSIZE;

                // NOTE: the padding schemes may result into different data length,
                //       while zero padding just fills up the last block PKCS7 might
                //       need an extra block to store its length information

                int nBufSize = nCount - nRest;
                int nFill;

                if (PaddingMode.PKCS7 == PaddingValue)
                {
                    nBufSize += Blowfish.BLOCKSIZE;
                    nFill = Blowfish.BLOCKSIZE - nRest;
                }
                else
                {
                    if (0 < nRest) nBufSize += Blowfish.BLOCKSIZE;
                    nFill = 0;
                }

                result = new byte[nBufSize];
                Array.Copy(inBuf, nOfs, result, 0, nCount);

                for (int nI = nCount; nI < nBufSize; nI++)
                {
                    result[nI] = (byte)nFill;
                }

                TransformBlock(result, 0, nBufSize, result, 0);
            }
            else
            {
                byte[] lastBlocks = new byte[nCount];
                if (0 < nCount)
                {
                    TransformBlock(inBuf, nOfs, nCount, lastBlocks, 0);

                    if (PaddingMode.PKCS7 == PaddingValue)
                    {
                        nCount -= lastBlocks[nCount - 1];
                    }

                    result = new byte[nCount];
                    Array.Copy(lastBlocks, 0, result, 0, nCount);
                }
                else
                {
                    // (that will be an empty array)
                    result = lastBlocks;
                }
            }

            return result;
        }
    }
}

namespace Blowfish_NET
{

    /// <summary>
    ///   helper class to enable CBCB for Blowfish
    /// </summary>
    /// <remarks>
    ///   Use this class to encrypt or decrypt byte arrays or a single
    ///   block with Blowfish in the CBC (Cipher Block Block Chaining) mode.
    /// </remarks>
    public class BlowfishCBC : Blowfish
    {

        uint m_unIvHi;
        uint m_unIvLo;


        /// <summary>
        ///   the current IV, Blowfish.BLOCKSIZE bytes large
        /// </summary>
        public byte[] Iv
        {
            set
            {
                m_unIvHi = (((uint)value[0]) << 24) |
                    (((uint)value[1]) << 16) |
                    (((uint)value[2]) << 8) |
                    ((uint)value[3]);

                m_unIvLo = (((uint)value[4]) << 24) |
                    (((uint)value[5]) << 16) |
                    (((uint)value[6]) << 8) |
                    ((uint)value[7]);
            }

            get
            {
                byte[] result = new byte[Blowfish.BLOCKSIZE];

                result[0] = (byte)(m_unIvHi >> 24);
                result[1] = (byte)(m_unIvHi >> 16);
                result[2] = (byte)(m_unIvHi >> 8);
                result[3] = (byte)m_unIvHi;
                result[4] = (byte)(m_unIvLo >> 24);
                result[5] = (byte)(m_unIvLo >> 16);
                result[6] = (byte)(m_unIvLo >> 8);
                result[7] = (byte)m_unIvLo;

                return result;
            }
        }


        /// <summary>
        ///   standard constructor
        /// </summary>
        /// <param name="key"> 
        ///   the key material, up to MAXKYELENGTH bytes, oversized material is ignored
        /// </param>
        /// <param name="iv"> 
        ///   the initialization vector as a byte array of Blowfish.BLOCKSIZE length,
        ///   no range checking, oversized data is ignored
        /// </param>
        public BlowfishCBC
            (byte[] key,
            byte[] iv)
            : base(key)
        {
            Iv = iv;
        }


        /// <summary>
        ///   deletes all internal data structures and invalidates this instance
        /// </summary>
        /// <remarks>
        ///   Call this method as soon as the work with a particular instance is
        ///   done. By this no sensitive translated key material remains. The
        ///   instance is invalid after this call and usage can lead to unexpected
        ///   results.
        /// </remarks> 
        public override void Burn()
        {
            base.Burn();

            m_unIvHi = m_unIvLo = 0;
        }


        /// <summary>
        ///   encrypts a single block
        /// </summary>
        /// <remarks>
        ///   Use this method to encrypt one logical block, which is passed
        ///   as two 32bit halves. If you extract the block from a sequence
        ///   of bytes you have to do it in the network byte order.
        /// </remarks>
        /// <param name="unHiRef">
        ///   reference to the high 32 bits of the block
        /// </param>
        /// <param name="unLoRef">
        ///   reference to the low 32 bits of the block
        /// </param>
        public override void Encrypt
            (ref uint unHiRef,
            ref uint unLoRef)
        {
            unHiRef ^= m_unIvHi;
            unLoRef ^= m_unIvLo;

            BaseEncrypt(ref unHiRef, ref unLoRef);

            m_unIvHi = unHiRef;
            m_unIvLo = unLoRef;
        }


        /// <summary>
        ///   decrypts a single block
        /// </summary>
        /// <remarks>
        ///   Use this method to decrypt one logical block, which is passed
        ///   as two 32bit halves. If you extract the block from a sequence
        ///   of bytes you have to do it in the network byte order.
        /// </remarks>
        /// <param name="unHiRef">
        ///   reference to the high 32 bits of the block
        /// </param>
        /// <param name="unLoRef">
        ///   reference to the low 32 bits of the block
        /// </param>
        public override void Decrypt
            (ref uint unHiRef,
            ref uint unLoRef)
        {
            uint unBakHi = unHiRef;
            uint unBakLo = unLoRef;

            base.Decrypt(ref unHiRef, ref unLoRef);

            unHiRef ^= m_unIvHi;
            unLoRef ^= m_unIvLo;

            m_unIvHi = unBakHi;
            m_unIvLo = unBakLo;
        }
    }
}

namespace Blowfish_NET
{

    /// <summary>
    /// Blowfish initialization values (PI hex)
    /// </summary>
    public class BlowfishTables
    {

        public static readonly uint[] pbox_init = 
		{

			0x243f6a88, 0x85a308d3, 0x13198a2e, 0x03707344, 0xa4093822, 0x299f31d0,
			0x082efa98, 0xec4e6c89, 0x452821e6, 0x38d01377, 0xbe5466cf, 0x34e90c6c,
			0xc0ac29b7, 0xc97c50dd, 0x3f84d5b5, 0xb5470917, 0x9216d5d9, 0x8979fb1b  
		};

        public static readonly uint[] sbox_init_1 = 
		{

			0xd1310ba6,   0x98dfb5ac,   0x2ffd72db,   0xd01adfb7,   0xb8e1afed,   0x6a267e96,
			0xba7c9045,   0xf12c7f99,   0x24a19947,   0xb3916cf7,   0x0801f2e2,   0x858efc16,
			0x636920d8,   0x71574e69,   0xa458fea3,   0xf4933d7e,   0x0d95748f,   0x728eb658,
			0x718bcd58,   0x82154aee,   0x7b54a41d,   0xc25a59b5,   0x9c30d539,   0x2af26013,
			0xc5d1b023,   0x286085f0,   0xca417918,   0xb8db38ef,   0x8e79dcb0,   0x603a180e,
			0x6c9e0e8b,   0xb01e8a3e,   0xd71577c1,   0xbd314b27,   0x78af2fda,   0x55605c60,
			0xe65525f3,   0xaa55ab94,   0x57489862,   0x63e81440,   0x55ca396a,   0x2aab10b6,
			0xb4cc5c34,   0x1141e8ce,   0xa15486af,   0x7c72e993,   0xb3ee1411,   0x636fbc2a,
			0x2ba9c55d,   0x741831f6,   0xce5c3e16,   0x9b87931e,   0xafd6ba33,   0x6c24cf5c,
			0x7a325381,   0x28958677,   0x3b8f4898,   0x6b4bb9af,   0xc4bfe81b,   0x66282193,
			0x61d809cc,   0xfb21a991,   0x487cac60,   0x5dec8032,   0xef845d5d,   0xe98575b1,
			0xdc262302,   0xeb651b88,   0x23893e81,   0xd396acc5,   0x0f6d6ff3,   0x83f44239,
			0x2e0b4482,   0xa4842004,   0x69c8f04a,   0x9e1f9b5e,   0x21c66842,   0xf6e96c9a,
			0x670c9c61,   0xabd388f0,   0x6a51a0d2,   0xd8542f68,   0x960fa728,   0xab5133a3,
			0x6eef0b6c,   0x137a3be4,   0xba3bf050,   0x7efb2a98,   0xa1f1651d,   0x39af0176,
			0x66ca593e,   0x82430e88,   0x8cee8619,   0x456f9fb4,   0x7d84a5c3,   0x3b8b5ebe,
			0xe06f75d8,   0x85c12073,   0x401a449f,   0x56c16aa6,   0x4ed3aa62,   0x363f7706,
			0x1bfedf72,   0x429b023d,   0x37d0d724,   0xd00a1248,   0xdb0fead3,   0x49f1c09b,
			0x075372c9,   0x80991b7b,   0x25d479d8,   0xf6e8def7,   0xe3fe501a,   0xb6794c3b,
			0x976ce0bd,   0x04c006ba,   0xc1a94fb6,   0x409f60c4,   0x5e5c9ec2,   0x196a2463,
			0x68fb6faf,   0x3e6c53b5,   0x1339b2eb,   0x3b52ec6f,   0x6dfc511f,   0x9b30952c,
			0xcc814544,   0xaf5ebd09,   0xbee3d004,   0xde334afd,   0x660f2807,   0x192e4bb3,
			0xc0cba857,   0x45c8740f,   0xd20b5f39,   0xb9d3fbdb,   0x5579c0bd,   0x1a60320a,
			0xd6a100c6,   0x402c7279,   0x679f25fe,   0xfb1fa3cc,   0x8ea5e9f8,   0xdb3222f8,
			0x3c7516df,   0xfd616b15,   0x2f501ec8,   0xad0552ab,   0x323db5fa,   0xfd238760,
			0x53317b48,   0x3e00df82,   0x9e5c57bb,   0xca6f8ca0,   0x1a87562e,   0xdf1769db,
			0xd542a8f6,   0x287effc3,   0xac6732c6,   0x8c4f5573,   0x695b27b0,   0xbbca58c8,
			0xe1ffa35d,   0xb8f011a0,   0x10fa3d98,   0xfd2183b8,   0x4afcb56c,   0x2dd1d35b,
			0x9a53e479,   0xb6f84565,   0xd28e49bc,   0x4bfb9790,   0xe1ddf2da,   0xa4cb7e33,
			0x62fb1341,   0xcee4c6e8,   0xef20cada,   0x36774c01,   0xd07e9efe,   0x2bf11fb4,
			0x95dbda4d,   0xae909198,   0xeaad8e71,   0x6b93d5a0,   0xd08ed1d0,   0xafc725e0,
			0x8e3c5b2f,   0x8e7594b7,   0x8ff6e2fb,   0xf2122b64,   0x8888b812,   0x900df01c,
			0x4fad5ea0,   0x688fc31c,   0xd1cff191,   0xb3a8c1ad,   0x2f2f2218,   0xbe0e1777,
			0xea752dfe,   0x8b021fa1,   0xe5a0cc0f,   0xb56f74e8,   0x18acf3d6,   0xce89e299,
			0xb4a84fe0,   0xfd13e0b7,   0x7cc43b81,   0xd2ada8d9,   0x165fa266,   0x80957705,
			0x93cc7314,   0x211a1477,   0xe6ad2065,   0x77b5fa86,   0xc75442f5,   0xfb9d35cf,
			0xebcdaf0c,   0x7b3e89a0,   0xd6411bd3,   0xae1e7e49,   0x00250e2d,   0x2071b35e,
			0x226800bb,   0x57b8e0af,   0x2464369b,   0xf009b91e,   0x5563911d,   0x59dfa6aa,
			0x78c14389,   0xd95a537f,   0x207d5ba2,   0x02e5b9c5,   0x83260376,   0x6295cfa9,
			0x11c81968,   0x4e734a41,   0xb3472dca,   0x7b14a94a,   0x1b510052,   0x9a532915,
			0xd60f573f,   0xbc9bc6e4,   0x2b60a476,   0x81e67400,   0x08ba6fb5,   0x571be91f,
			0xf296ec6b,   0x2a0dd915,   0xb6636521,   0xe7b9f9b6,   0xff34052e,   0xc5855664,
			0x53b02d5d,   0xa99f8fa1,   0x08ba4799,   0x6e85076a 
		};


        public static readonly uint[] sbox_init_2 = 
		{

			0x4b7a70e9,   0xb5b32944,
			0xdb75092e,   0xc4192623,   0xad6ea6b0,   0x49a7df7d,   0x9cee60b8,   0x8fedb266,
			0xecaa8c71,   0x699a17ff,   0x5664526c,   0xc2b19ee1,   0x193602a5,   0x75094c29,
			0xa0591340,   0xe4183a3e,   0x3f54989a,   0x5b429d65,   0x6b8fe4d6,   0x99f73fd6,
			0xa1d29c07,   0xefe830f5,   0x4d2d38e6,   0xf0255dc1,   0x4cdd2086,   0x8470eb26,
			0x6382e9c6,   0x021ecc5e,   0x09686b3f,   0x3ebaefc9,   0x3c971814,   0x6b6a70a1,
			0x687f3584,   0x52a0e286,   0xb79c5305,   0xaa500737,   0x3e07841c,   0x7fdeae5c,
			0x8e7d44ec,   0x5716f2b8,   0xb03ada37,   0xf0500c0d,   0xf01c1f04,   0x0200b3ff,
			0xae0cf51a,   0x3cb574b2,   0x25837a58,   0xdc0921bd,   0xd19113f9,   0x7ca92ff6,
			0x94324773,   0x22f54701,   0x3ae5e581,   0x37c2dadc,   0xc8b57634,   0x9af3dda7,
			0xa9446146,   0x0fd0030e,   0xecc8c73e,   0xa4751e41,   0xe238cd99,   0x3bea0e2f,
			0x3280bba1,   0x183eb331,   0x4e548b38,   0x4f6db908,   0x6f420d03,   0xf60a04bf,
			0x2cb81290,   0x24977c79,   0x5679b072,   0xbcaf89af,   0xde9a771f,   0xd9930810,
			0xb38bae12,   0xdccf3f2e,   0x5512721f,   0x2e6b7124,   0x501adde6,   0x9f84cd87,
			0x7a584718,   0x7408da17,   0xbc9f9abc,   0xe94b7d8c,   0xec7aec3a,   0xdb851dfa,
			0x63094366,   0xc464c3d2,   0xef1c1847,   0x3215d908,   0xdd433b37,   0x24c2ba16,
			0x12a14d43,   0x2a65c451,   0x50940002,   0x133ae4dd,   0x71dff89e,   0x10314e55,
			0x81ac77d6,   0x5f11199b,   0x043556f1,   0xd7a3c76b,   0x3c11183b,   0x5924a509,
			0xf28fe6ed,   0x97f1fbfa,   0x9ebabf2c,   0x1e153c6e,   0x86e34570,   0xeae96fb1,
			0x860e5e0a,   0x5a3e2ab3,   0x771fe71c,   0x4e3d06fa,   0x2965dcb9,   0x99e71d0f,
			0x803e89d6,   0x5266c825,   0x2e4cc978,   0x9c10b36a,   0xc6150eba,   0x94e2ea78,
			0xa5fc3c53,   0x1e0a2df4,   0xf2f74ea7,   0x361d2b3d,   0x1939260f,   0x19c27960,
			0x5223a708,   0xf71312b6,   0xebadfe6e,   0xeac31f66,   0xe3bc4595,   0xa67bc883,
			0xb17f37d1,   0x018cff28,   0xc332ddef,   0xbe6c5aa5,   0x65582185,   0x68ab9802,
			0xeecea50f,   0xdb2f953b,   0x2aef7dad,   0x5b6e2f84,   0x1521b628,   0x29076170,
			0xecdd4775,   0x619f1510,   0x13cca830,   0xeb61bd96,   0x0334fe1e,   0xaa0363cf,
			0xb5735c90,   0x4c70a239,   0xd59e9e0b,   0xcbaade14,   0xeecc86bc,   0x60622ca7,
			0x9cab5cab,   0xb2f3846e,   0x648b1eaf,   0x19bdf0ca,   0xa02369b9,   0x655abb50,
			0x40685a32,   0x3c2ab4b3,   0x319ee9d5,   0xc021b8f7,   0x9b540b19,   0x875fa099,
			0x95f7997e,   0x623d7da8,   0xf837889a,   0x97e32d77,   0x11ed935f,   0x16681281,
			0x0e358829,   0xc7e61fd6,   0x96dedfa1,   0x7858ba99,   0x57f584a5,   0x1b227263,
			0x9b83c3ff,   0x1ac24696,   0xcdb30aeb,   0x532e3054,   0x8fd948e4,   0x6dbc3128,
			0x58ebf2ef,   0x34c6ffea,   0xfe28ed61,   0xee7c3c73,   0x5d4a14d9,   0xe864b7e3,
			0x42105d14,   0x203e13e0,   0x45eee2b6,   0xa3aaabea,   0xdb6c4f15,   0xfacb4fd0,
			0xc742f442,   0xef6abbb5,   0x654f3b1d,   0x41cd2105,   0xd81e799e,   0x86854dc7,
			0xe44b476a,   0x3d816250,   0xcf62a1f2,   0x5b8d2646,   0xfc8883a0,   0xc1c7b6a3,
			0x7f1524c3,   0x69cb7492,   0x47848a0b,   0x5692b285,   0x095bbf00,   0xad19489d,
			0x1462b174,   0x23820e00,   0x58428d2a,   0x0c55f5ea,   0x1dadf43e,   0x233f7061,
			0x3372f092,   0x8d937e41,   0xd65fecf1,   0x6c223bdb,   0x7cde3759,   0xcbee7460,
			0x4085f2a7,   0xce77326e,   0xa6078084,   0x19f8509e,   0xe8efd855,   0x61d99735,
			0xa969a7aa,   0xc50c06c2,   0x5a04abfc,   0x800bcadc,   0x9e447a2e,   0xc3453484,
			0xfdd56705,   0x0e1e9ec9,   0xdb73dbd3,   0x105588cd,   0x675fda79,   0xe3674340,
			0xc5c43465,   0x713e38d8,   0x3d28f89e,   0xf16dff20,   0x153e21e7,   0x8fb03d4a,
			0xe6e39f2b,   0xdb83adf7 
		};

        public static readonly uint[] sbox_init_3 = 
		{

			0xe93d5a68,   0x948140f7,   0xf64c261c,   0x94692934,
			0x411520f7,   0x7602d4f7,   0xbcf46b2e,   0xd4a20068,   0xd4082471,   0x3320f46a,
			0x43b7d4b7,   0x500061af,   0x1e39f62e,   0x97244546,   0x14214f74,   0xbf8b8840,
			0x4d95fc1d,   0x96b591af,   0x70f4ddd3,   0x66a02f45,   0xbfbc09ec,   0x03bd9785,
			0x7fac6dd0,   0x31cb8504,   0x96eb27b3,   0x55fd3941,   0xda2547e6,   0xabca0a9a,
			0x28507825,   0x530429f4,   0x0a2c86da,   0xe9b66dfb,   0x68dc1462,   0xd7486900,
			0x680ec0a4,   0x27a18dee,   0x4f3ffea2,   0xe887ad8c,   0xb58ce006,   0x7af4d6b6,
			0xaace1e7c,   0xd3375fec,   0xce78a399,   0x406b2a42,   0x20fe9e35,   0xd9f385b9,
			0xee39d7ab,   0x3b124e8b,   0x1dc9faf7,   0x4b6d1856,   0x26a36631,   0xeae397b2,
			0x3a6efa74,   0xdd5b4332,   0x6841e7f7,   0xca7820fb,   0xfb0af54e,   0xd8feb397,
			0x454056ac,   0xba489527,   0x55533a3a,   0x20838d87,   0xfe6ba9b7,   0xd096954b,
			0x55a867bc,   0xa1159a58,   0xcca92963,   0x99e1db33,   0xa62a4a56,   0x3f3125f9,
			0x5ef47e1c,   0x9029317c,   0xfdf8e802,   0x04272f70,   0x80bb155c,   0x05282ce3,
			0x95c11548,   0xe4c66d22,   0x48c1133f,   0xc70f86dc,   0x07f9c9ee,   0x41041f0f,
			0x404779a4,   0x5d886e17,   0x325f51eb,   0xd59bc0d1,   0xf2bcc18f,   0x41113564,
			0x257b7834,   0x602a9c60,   0xdff8e8a3,   0x1f636c1b,   0x0e12b4c2,   0x02e1329e,
			0xaf664fd1,   0xcad18115,   0x6b2395e0,   0x333e92e1,   0x3b240b62,   0xeebeb922,
			0x85b2a20e,   0xe6ba0d99,   0xde720c8c,   0x2da2f728,   0xd0127845,   0x95b794fd,
			0x647d0862,   0xe7ccf5f0,   0x5449a36f,   0x877d48fa,   0xc39dfd27,   0xf33e8d1e,
			0x0a476341,   0x992eff74,   0x3a6f6eab,   0xf4f8fd37,   0xa812dc60,   0xa1ebddf8,
			0x991be14c,   0xdb6e6b0d,   0xc67b5510,   0x6d672c37,   0x2765d43b,   0xdcd0e804,
			0xf1290dc7,   0xcc00ffa3,   0xb5390f92,   0x690fed0b,   0x667b9ffb,   0xcedb7d9c,
			0xa091cf0b,   0xd9155ea3,   0xbb132f88,   0x515bad24,   0x7b9479bf,   0x763bd6eb,
			0x37392eb3,   0xcc115979,   0x8026e297,   0xf42e312d,   0x6842ada7,   0xc66a2b3b,
			0x12754ccc,   0x782ef11c,   0x6a124237,   0xb79251e7,   0x06a1bbe6,   0x4bfb6350,
			0x1a6b1018,   0x11caedfa,   0x3d25bdd8,   0xe2e1c3c9,   0x44421659,   0x0a121386,
			0xd90cec6e,   0xd5abea2a,   0x64af674e,   0xda86a85f,   0xbebfe988,   0x64e4c3fe,
			0x9dbc8057,   0xf0f7c086,   0x60787bf8,   0x6003604d,   0xd1fd8346,   0xf6381fb0,
			0x7745ae04,   0xd736fccc,   0x83426b33,   0xf01eab71,   0xb0804187,   0x3c005e5f,
			0x77a057be,   0xbde8ae24,   0x55464299,   0xbf582e61,   0x4e58f48f,   0xf2ddfda2,
			0xf474ef38,   0x8789bdc2,   0x5366f9c3,   0xc8b38e74,   0xb475f255,   0x46fcd9b9,
			0x7aeb2661,   0x8b1ddf84,   0x846a0e79,   0x915f95e2,   0x466e598e,   0x20b45770,
			0x8cd55591,   0xc902de4c,   0xb90bace1,   0xbb8205d0,   0x11a86248,   0x7574a99e,
			0xb77f19b6,   0xe0a9dc09,   0x662d09a1,   0xc4324633,   0xe85a1f02,   0x09f0be8c,
			0x4a99a025,   0x1d6efe10,   0x1ab93d1d,   0x0ba5a4df,   0xa186f20f,   0x2868f169,
			0xdcb7da83,   0x573906fe,   0xa1e2ce9b,   0x4fcd7f52,   0x50115e01,   0xa70683fa,
			0xa002b5c4,   0x0de6d027,   0x9af88c27,   0x773f8641,   0xc3604c06,   0x61a806b5,
			0xf0177a28,   0xc0f586e0,   0x006058aa,   0x30dc7d62,   0x11e69ed7,   0x2338ea63,
			0x53c2dd94,   0xc2c21634,   0xbbcbee56,   0x90bcb6de,   0xebfc7da1,   0xce591d76,
			0x6f05e409,   0x4b7c0188,   0x39720a3d,   0x7c927c24,   0x86e3725f,   0x724d9db9,
			0x1ac15bb4,   0xd39eb8fc,   0xed545578,   0x08fca5b5,   0xd83d7cd3,   0x4dad0fc4,
			0x1e50ef5e,   0xb161e6f8,   0xa28514d9,   0x6c51133c,   0x6fd5c7e7,   0x56e14ec4,
			0x362abfce,   0xddc6c837,   0xd79a3234,   0x92638212,   0x670efa8e,   0x406000e0 
		};

        public static readonly uint[] sbox_init_4 = 
		{

			0x3a39ce37,   0xd3faf5cf,   0xabc27737,   0x5ac52d1b,   0x5cb0679e,   0x4fa33742,
			0xd3822740,   0x99bc9bbe,   0xd5118e9d,   0xbf0f7315,   0xd62d1c7e,   0xc700c47b,
			0xb78c1b6b,   0x21a19045,   0xb26eb1be,   0x6a366eb4,   0x5748ab2f,   0xbc946e79,
			0xc6a376d2,   0x6549c2c8,   0x530ff8ee,   0x468dde7d,   0xd5730a1d,   0x4cd04dc6,
			0x2939bbdb,   0xa9ba4650,   0xac9526e8,   0xbe5ee304,   0xa1fad5f0,   0x6a2d519a,
			0x63ef8ce2,   0x9a86ee22,   0xc089c2b8,   0x43242ef6,   0xa51e03aa,   0x9cf2d0a4,
			0x83c061ba,   0x9be96a4d,   0x8fe51550,   0xba645bd6,   0x2826a2f9,   0xa73a3ae1,
			0x4ba99586,   0xef5562e9,   0xc72fefd3,   0xf752f7da,   0x3f046f69,   0x77fa0a59,
			0x80e4a915,   0x87b08601,   0x9b09e6ad,   0x3b3ee593,   0xe990fd5a,   0x9e34d797,
			0x2cf0b7d9,   0x022b8b51,   0x96d5ac3a,   0x017da67d,   0xd1cf3ed6,   0x7c7d2d28,
			0x1f9f25cf,   0xadf2b89b,   0x5ad6b472,   0x5a88f54c,   0xe029ac71,   0xe019a5e6,
			0x47b0acfd,   0xed93fa9b,   0xe8d3c48d,   0x283b57cc,   0xf8d56629,   0x79132e28,
			0x785f0191,   0xed756055,   0xf7960e44,   0xe3d35e8c,   0x15056dd4,   0x88f46dba,
			0x03a16125,   0x0564f0bd,   0xc3eb9e15,   0x3c9057a2,   0x97271aec,   0xa93a072a,
			0x1b3f6d9b,   0x1e6321f5,   0xf59c66fb,   0x26dcf319,   0x7533d928,   0xb155fdf5,
			0x03563482,   0x8aba3cbb,   0x28517711,   0xc20ad9f8,   0xabcc5167,   0xccad925f,
			0x4de81751,   0x3830dc8e,   0x379d5862,   0x9320f991,   0xea7a90c2,   0xfb3e7bce,
			0x5121ce64,   0x774fbe32,   0xa8b6e37e,   0xc3293d46,   0x48de5369,   0x6413e680,
			0xa2ae0810,   0xdd6db224,   0x69852dfd,   0x09072166,   0xb39a460a,   0x6445c0dd,
			0x586cdecf,   0x1c20c8ae,   0x5bbef7dd,   0x1b588d40,   0xccd2017f,   0x6bb4e3bb,
			0xdda26a7e,   0x3a59ff45,   0x3e350a44,   0xbcb4cdd5,   0x72eacea8,   0xfa6484bb,
			0x8d6612ae,   0xbf3c6f47,   0xd29be463,   0x542f5d9e,   0xaec2771b,   0xf64e6370,
			0x740e0d8d,   0xe75b1357,   0xf8721671,   0xaf537d5d,   0x4040cb08,   0x4eb4e2cc,
			0x34d2466a,   0x0115af84,   0xe1b00428,   0x95983a1d,   0x06b89fb4,   0xce6ea048,
			0x6f3f3b82,   0x3520ab82,   0x011a1d4b,   0x277227f8,   0x611560b1,   0xe7933fdc,
			0xbb3a792b,   0x344525bd,   0xa08839e1,   0x51ce794b,   0x2f32c9b7,   0xa01fbac9,
			0xe01cc87e,   0xbcc7d1f6,   0xcf0111c3,   0xa1e8aac7,   0x1a908749,   0xd44fbd9a,
			0xd0dadecb,   0xd50ada38,   0x0339c32a,   0xc6913667,   0x8df9317c,   0xe0b12b4f,
			0xf79e59b7,   0x43f5bb3a,   0xf2d519ff,   0x27d9459c,   0xbf97222c,   0x15e6fc2a,
			0x0f91fc71,   0x9b941525,   0xfae59361,   0xceb69ceb,   0xc2a86459,   0x12baa8d1,
			0xb6c1075e,   0xe3056a0c,   0x10d25065,   0xcb03a442,   0xe0ec6e0e,   0x1698db3b,
			0x4c98a0be,   0x3278e964,   0x9f1f9532,   0xe0d392df,   0xd3a0342b,   0x8971f21e,
			0x1b0a7441,   0x4ba3348c,   0xc5be7120,   0xc37632d8,   0xdf359f8d,   0x9b992f2e,
			0xe60b6f47,   0x0fe3f11d,   0xe54cda54,   0x1edad891,   0xce6279cf,   0xcd3e7e6f,
			0x1618b166,   0xfd2c1d05,   0x848fd2c5,   0xf6fb2299,   0xf523f357,   0xa6327623,
			0x93a83531,   0x56cccd02,   0xacf08162,   0x5a75ebb5,   0x6e163697,   0x88d273cc,
			0xde966292,   0x81b949d0,   0x4c50901b,   0x71c65614,   0xe6c6c7bd,   0x327a140a,
			0x45e1d006,   0xc3f27b9a,   0xc9aa53fd,   0x62a80f00,   0xbb25bfe2,   0x35bdd2f6,
			0x71126905,   0xb2040222,   0xb6cbcf7c,   0xcd769c2b,   0x53113ec0,   0x1640e3d3,
			0x38abbd60,   0x2547adf0,   0xba38209c,   0xf746ce76,   0x77afa1c5,   0x20756060,
			0x85cbfe4e,   0x8ae88dd8,   0x7aaaf9b0,   0x4cf9aa7e,   0x1948c25c,   0x02fb8a8c,
			0x01c36ae4,   0xd6ebe1f9,   0x90d4f869,   0xa65cdea0,   0x3f09252d,   0xc208e69f,
			0xb74e6132,   0xce77e25b,   0x578fdfe3,   0x3ac372e6 
		};
    }
}
