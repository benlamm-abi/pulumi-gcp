// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * ## get the public key to encrypt the secret with
 *
 * $ gcloud kms keys versions get-public-key 1\
 *   --project my-project\
 *   --location us-central1\
 *   --keyring my-key-ring\
 *   --key my-crypto-key\
 *   --output-file public-key.pem
 *
 * ## encrypt secret with the public key
 *
 * $ echo -n my-secret-password |\
 *   openssl pkeyutl -in -\
 *     -encrypt\
 *     -pubin\
 *     -inkey public-key.pem\
 *     -pkeyopt rsa_padding_mode:oaep\
 *     -pkeyopt rsa_oaep_md:sha256\
 *     -pkeyopt rsa_mgf1_md:sha256 >\
 *   my-secret-password.enc
 *
 * ## base64 encode the ciphertext
 *
 * $ openssl base64 -in my-secret-password.enc
 * M7nUoba9EGVTu2LjNjBKGdGVBYjyS/i/AY+4yQMQF0Qf/RfUfX31Jw6+VO9OuThq
 * ylu/7ihX9XD4bM7yYdXnMv9p1OHQUlorSBSbb/J6n1W9UJhcp6um8Tw8/Isx4f75
 * 4PskYS6f8Y2ItliGt1/A9iR5BTgGtJBwOxMlgoX2Ggq+Nh4E5SbdoaE5o6CO1nBx
 * eIPsPEebQ6qC4JehQM3IGuV/lrm58+hZhaXAqNzX1cEYyAt5GYqJIVCiI585SUYs
 * wRToGyTgaN+zthF0HP9IWlR4Am4LmJ/1OcePTnYw11CkU8wNRbDzVAzogwNH+rXr
 * LTmf7hxVjBm6bBSVSNFcBKAXFlllubSfIeZ5hgzGqn54OmSf6odO12L5JxllddHc
 * yAd54vWKs2kJtnsKV2V4ZdkI0w6y1TeI67baFZDNGo6qsCpFMPnvv7d46Pg2VOp1
 * J6Ivner0NnNHE4MzNmpZRk8WXMwqq4P/gTiT7F/aCX6oFCUQ4AWPQhJYh2dkcOmL
 * IP+47Veb10aFn61F1CJwpmOOiGNXKdDT1vK8CMnnwhm825K0q/q9Zqpzc1+1ae1z
 * mSqol1zCoa88CuSN6nTLQlVnN/dzfrGbc0boJPaM0iGhHtSzHk4SWg84LhiJB1q9
 * A9XFJmOVdkvRY9nnz/iVLAdd0Q3vFtLqCdUYsNN2yh4=
 */
export function getKMSSecretAsymmetric(args: GetKMSSecretAsymmetricArgs, opts?: pulumi.InvokeOptions): Promise<GetKMSSecretAsymmetricResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("gcp:kms/getKMSSecretAsymmetric:getKMSSecretAsymmetric", {
        "ciphertext": args.ciphertext,
        "crc32": args.crc32,
        "cryptoKeyVersion": args.cryptoKeyVersion,
    }, opts);
}

/**
 * A collection of arguments for invoking getKMSSecretAsymmetric.
 */
export interface GetKMSSecretAsymmetricArgs {
    /**
     * The ciphertext to be decrypted, encoded in base64
     */
    ciphertext: string;
    /**
     * The crc32 checksum of the `ciphertext` in hexadecimal notation. If not specified, it will be computed.
     */
    crc32?: string;
    /**
     * The id of the CryptoKey version that will be used to
     * decrypt the provided ciphertext. This is represented by the format
     * `projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}/cryptoKeyVersions/{version}`.
     */
    cryptoKeyVersion: string;
}

/**
 * A collection of values returned by getKMSSecretAsymmetric.
 */
export interface GetKMSSecretAsymmetricResult {
    readonly ciphertext: string;
    /**
     * Contains the crc32 checksum of the provided ciphertext.
     */
    readonly crc32?: string;
    readonly cryptoKeyVersion: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Contains the result of decrypting the provided ciphertext.
     */
    readonly plaintext: string;
}

export function getKMSSecretAsymmetricOutput(args: GetKMSSecretAsymmetricOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKMSSecretAsymmetricResult> {
    return pulumi.output(args).apply(a => getKMSSecretAsymmetric(a, opts))
}

/**
 * A collection of arguments for invoking getKMSSecretAsymmetric.
 */
export interface GetKMSSecretAsymmetricOutputArgs {
    /**
     * The ciphertext to be decrypted, encoded in base64
     */
    ciphertext: pulumi.Input<string>;
    /**
     * The crc32 checksum of the `ciphertext` in hexadecimal notation. If not specified, it will be computed.
     */
    crc32?: pulumi.Input<string>;
    /**
     * The id of the CryptoKey version that will be used to
     * decrypt the provided ciphertext. This is represented by the format
     * `projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}/cryptoKeyVersions/{version}`.
     */
    cryptoKeyVersion: pulumi.Input<string>;
}
