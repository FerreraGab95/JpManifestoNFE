namespace JpManifestoNFE.DistribuicaoDFe
{
    /// <summary>
    /// Processa a mensagem de retorno da distribuição DFe;
    /// </summary>
    internal static class RetornoDFeProcessor
    {

        /// <summary>
        /// Extrai e processa todos os documentos da mensagem de retorno da DistribuicaoDFe;
        /// </summary>
        /// <returns></returns>
        /*internal static List<DFeDoc> GetRetornoDocs(retDistDFeInt retornoDFe)
        {
            var docsExtraidos = new List<DFeDoc>();

            foreach(var xmlDocZip in retornoDFe.loteDistDFeInt.docZip)
            {
                using (Stream docStream = ExtractDocXmlContent(xmlDocZip.Value))
                {
                    if (xmlDocZip.schema.Contains(nameof(resNFe)))
                    {
                        var docResNfe = new DFeDocResumoNFe();
                        docResNfe.NSU = long.Parse(xmlDocZip.NSU);
                        docResNfe.ResumoNFe = (resNFe)ParseXmlContentToObject(typeof(resNFe), docStream);
                        docsExtraidos.Add(docResNfe);
                    }
                    else if (xmlDocZip.schema.Contains(nameof(resEvento)))
                    {
                        var docResEvento = new DFeDocResumoEvento();
                        docResEvento.NSU = long.Parse(xmlDocZip.NSU);
                        docResEvento.ResumoEvento = (resEvento)ParseXmlContentToObject(typeof(resEvento), docStream);
                        docsExtraidos.Add(docResEvento);
                    }*/
        /*O nome procNFe existe apenas no arquivo schema, o tipo da NFe processada é TProtNFe
         o motivo de tal divergência é desconhecido, talvez seja resolvido em uma futura atualização
        dos web services.*/
        /*else if (xmlDocZip.schema.Contains("procNFe"))
        {
            var docProcNFe = new DFeDocProcNFe();
            docProcNFe.NSU = long.Parse(xmlDocZip.NSU);
            docProcNFe.NFeProc = (TNfeProc)ParseXmlContentToObject(typeof(TNfeProc), docStream);
            docsExtraidos.Add(docProcNFe);
        }
        else if (xmlDocZip.schema.Contains("procEventoNFe"))
        {
            var procEventoNFe = new DFeProcEventoNFe();
            procEventoNFe.NSU = long.Parse(xmlDocZip.NSU);
            procEventoNFe.procEventoNFe = (TProcEvento)ParseXmlContentToObject(typeof(TProcEvento), 
                docStream, (int)procEventoNFe.NSU);
        }
        else
        {
            var docDesc = new DFeDocDesc();
            docDesc.NSU = long.Parse(xmlDocZip.NSU);
            docDesc.ConteudoDoc = (string)ParseXmlContentToObject(typeof(object), docStream);
            docsExtraidos.Add(docDesc);
        }
    }
}

return docsExtraidos;
}*/
    }
}
