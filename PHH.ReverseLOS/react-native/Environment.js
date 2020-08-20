const ENV = {
  dev: {
    apiUrl: 'http://localhost:44341',
    oAuthConfig: {
      issuer: 'http://localhost:44341',
      clientId: 'ReverseLOS_App',
      clientSecret: '1q2w3e*',
      scope: 'ReverseLOS',
    },
    localization: {
      defaultResourceName: 'ReverseLOS',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44341',
    oAuthConfig: {
      issuer: 'http://localhost:44341',
      clientId: 'ReverseLOS_App',
      clientSecret: '1q2w3e*',
      scope: 'ReverseLOS',
    },
    localization: {
      defaultResourceName: 'ReverseLOS',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
